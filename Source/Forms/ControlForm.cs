using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace NumSystem
{
    public partial class ControlForm : Form
    {
        [DllImport("shell32.dll")]
        static extern IntPtr ExtractIcon(IntPtr hInst, string FileName, int nIconIndex);

        private static string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
        private static string DBFileName = AppPath + "\\" + P.dbFileName;

        public ControlForm()
        {
            Text = P.adminCaption;
            Icon = System.Drawing.Icon.FromHandle(ExtractIcon(IntPtr.Zero, Application.ExecutablePath, 1));
            InitializeComponent();
            checkCalc.Checked = Reg.ShowCalculator;
            checkDB.Checked = Reg.ShowDB;
            checkFolder.Checked = Reg.ShowFolder;
            textLastLD.Text += Reg.LastLaunchDate;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string newPassword = Interaction.InputBox("Введіть новий пароль", P.adminCaption);
            if (newPassword != "") Reg.Password = newPassword;
        }

        private void checkCalc_CheckedChanged(object sender, EventArgs e)
        {
            Reg.ShowCalculator = checkCalc.Checked;
        }

        private void checkDB_CheckedChanged(object sender, EventArgs e)
        {
            Reg.ShowDB = checkDB.Checked;
            if (checkDB.Checked) File.SetAttributes(DBFileName, FileAttributes.Normal);
            else File.SetAttributes(DBFileName, FileAttributes.Hidden | FileAttributes.System);
        }

        private void checkFolder_CheckedChanged(object sender, EventArgs e)
        {
            Reg.ShowFolder = checkFolder.Checked;
            if (checkFolder.Checked) File.SetAttributes(AppPath, FileAttributes.Normal);
            else File.SetAttributes(AppPath, FileAttributes.Hidden | FileAttributes.System);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(DBFileName);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new ViewerForm().Show();
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                Hide();
                e.Cancel = true;
            }
        }
    }
}