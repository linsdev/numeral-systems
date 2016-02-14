using System;
using System.Windows.Forms;

namespace NumSystem
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            Text = P.adminCaption + " → перегляд бази данних";
            InitializeComponent();
            P.InitDB();
        }

        private void ViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            P.CloseDB();
            Application.OpenForms["ControlForm"].Show();
        }
    }
}