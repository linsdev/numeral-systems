using System;
using System.Windows.Forms;

namespace NumSystem
{
    public partial class ResultForm : Form
    {
        public ResultForm(byte Good, byte Count)
        {
            InitializeComponent();

            textGood.Text += Good.ToString();
            textCount.Text += Count.ToString();

            switch (4 * Good / Count)
            {
                case 0:
                    pictureBox.Image = Resources.Res.very_bad;
                    break;

                case 1:
                    pictureBox.Image = Resources.Res.bad;
                    break;

                case 2:
                    pictureBox.Image = Resources.Res.good;
                    break;

                case 3:
                case 4:
                    pictureBox.Image = Resources.Res.very_good;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
