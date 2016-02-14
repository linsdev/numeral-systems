using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace NumSystem
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
