using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NumSystem
{
    public partial class SelectPupilForm : Form
    {
        private byte selectClass;

        public SelectPupilForm()
        {
            InitializeComponent();

            textClass.Font = comboClass.Font = textName.Font = comboName.Font =
                textSurname.Font = comboSurname.Font = textPassword.Font = editPassword.Font =
                new Font("Tahoma", 40, FontStyle.Regular, GraphicsUnit.Point);

            comboClass.Left = comboName.Left = comboSurname.Left = editPassword.Left =
                (SystemInformation.PrimaryMonitorSize.Width - comboClass.Width) / 2 + 150;
            textClass.Left = textName.Left = textSurname.Left = textPassword.Left =
                comboSurname.Left - textSurname.Width - 10;
            comboName.Top = SystemInformation.PrimaryMonitorSize.Height / 2 - 20;
            textSurname.Top = comboSurname.Top = comboName.Top + 40;
            textPassword.Top = editPassword.Top = comboSurname.Top + comboSurname.Height + 80;
            textName.Top = comboName.Top -= comboName.Height + 40;
            textClass.Top = comboClass.Top = comboName.Top - comboClass.Height - 80;
            
            foreach (DataRow row in P.Forms.Rows)
                comboClass.Items.Add(row[1].ToString()+"‒"+row[2]);

            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(new System.Globalization.CultureInfo("uk-UA"));
        }

        void GetClassLetter(string text, out string Class, out string Letter)
        {
            int sp = text.IndexOf('‒');
            if (sp > 0)
            {
                Class = text.Remove(sp);
                Letter = text.Remove(0, sp + 1);
            }
            else
            {
                Class = text;
                Letter = "";
            }
        }

        private void SelectPupilForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    Close();
                    break;
                case Keys.Enter:
                    if (comboClass.Text == "" || comboName.Text == "" ||
                        comboSurname.Text == "" || editPassword.Text == "")
                        MessageBox.Show("Не всі данні введені");
                    else
                    {
                        string Class, Letter;
                        GetClassLetter(comboClass.Text, out Class, out Letter);
                        selectClass = P.Forms.AddRecord(Class, Letter);
                        DataRow row = P.Pupils.AddRecord(selectClass, comboName.Text, comboSurname.Text,
                            editPassword.Text, DateTime.Now);
                        if ((string)row["Пароль"] != editPassword.Text)
                        {
                            MessageBox.Show("Пароль не вірний");
                            return;
                        }
                        ((MainForm)this.Owner).pupil = Convert.ToUInt16(row[0]);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    break;
            }
        }

        private void comboClass_Leave(object sender, EventArgs e)
        {
            if (comboClass.Text != "")
            {
                comboClass.Text = comboClass.Text.ToUpper();
                comboName.Items.Clear();
                comboSurname.Items.Clear();

                if (!(new Regex(@"\d{1,2}‒[А-Д]").Match(comboClass.Text).Success))
                {
                    comboClass.Text = "";
                    MessageBox.Show("Такого класу не буває!");
                    comboClass.Focus();
                    return;
                }

                string Class, Letter;
                GetClassLetter(comboClass.Text, out Class, out Letter);
                selectClass = P.Forms.GetCode(Class, Letter);
                DataRow[] cr = P.Forms.GetPupilsRows(selectClass);
                if (cr == null) return;
                foreach (DataRow row in cr)
                {
                    comboName.Items.Add((string)row[1]);
                    comboSurname.Items.Add((string)row[2]);
                }
            }
        }

        private void comboName_Leave(object sender, EventArgs e)
        {
            if (comboName.Text != "")
            {
                comboSurname.Items.Clear();
                foreach (DataRow row in P.Pupils.Select(string.Format(
                    "Клас={0} AND Ім’я='{1}'", selectClass, comboName.Text)))
                    comboSurname.Items.Add((string)row[2]);
            }
        }

        private void comboClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-') e.KeyChar = '‒';
        }

        private void comboName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((ComboBox)sender).SelectedText == ((ComboBox)sender).Text)
            {
                ((ComboBox)sender).Text = "";
                e.KeyChar = char.ToUpper(e.KeyChar);
                return;
            }
            if (((ComboBox)sender).Text == "") e.KeyChar = char.ToUpper(e.KeyChar);
            else e.KeyChar = char.ToLower(e.KeyChar);
        }
    }
}