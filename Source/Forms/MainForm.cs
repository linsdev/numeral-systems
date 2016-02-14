using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;

namespace NumSystem
{
    public partial class MainForm : Form
    {
        static string NewLine = Environment.NewLine;
        Font smallFont = new Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Point);
        Font largeFont = new Font("Calibri", 35, FontStyle.Regular, GraphicsUnit.Point);

        public ushort pupil = 0;
        Task task;

        Rnd r = new Rnd();

        delegate long function(long X, long Y);
        Dictionary<TestType, function> operations = new Dictionary<TestType, function>
        {
            { TestType.Addition,        (x, y) => x + y },
            { TestType.Substraction,    (x, y) => x - y },
            { TestType.Multiplication,  (x, y) => x * y },
            { TestType.Division,        (x, y) => x / y },
        };

        public MainForm()
        {
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
            SetStateMenu();
            int width = SystemInformation.PrimaryMonitorSize.Width;
            int height = SystemInformation.PrimaryMonitorSize.Height;

            comboTestType.Left = (width - comboTestType.Width) / 2;

            pictureBtnClose.Left = width - 30;
            pictureBtnClose.Image = Resources.Res.Btn;

            btnTheory.Width = btnPassExam.Width = btnTestStart.Width = width - 240;
            btnTestStart.Top = height / 2 - 40;
            btnTheory.Top = btnTestStart.Top - 110;
            btnPassExam.Top = btnTestStart.Top + 110;

            if (Reg.Exist && !Reg.ShowCalculator)
            {
                editCalc.Visible = false;
                textTask.Width = width - 120;
                editSolution.Width = width - 480;
                editSolution.Left = 240;
            }
            else
            {
                int widthP5 = width / 5;
                textTask.Width = 3 * widthP5 - 100;
                editSolution.Width = textTask.Width;
                editCalc.Width = 2 * widthP5 - 60;
                editCalc.Left = textTask.Width + 100;
                editCalc.Height = height - editCalc.Top - 45;
            }
            textTask.Height = 14 * height / 25;
            editSolution.Top = textTask.Top + textTask.Height + 5;

            comboRadix.Font = textRadix.Font = editTestLevel.Font = textTestLevel.Font = largeFont;

            statusBarFormText.Width = width / 10;
            statusBarNameText.Width = statusBarFormText.Width * 2;
            statusBarSurnameText.Width = statusBarNameText.Width;
            statusBarTastProgress.Width = statusBarFormText.Width * 5;

            if (Reg.Exist) Reg.LastLaunchDate = DateTime.Now.ToString();
        }

        private void pictureBtnClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBtnClose.Image = Resources.Res.Btn;
        }

        private void pictureBtnClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBtnClose.Image = Resources.Res.Btn_Activ;
        }

        private void pictureBtnClose_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBtnClose.Image = Resources.Res.Btn_Down;
        }

        private void pictureBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void editCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                if (editCalc.Text == "") return;
                string s = editCalc.Lines[editCalc.Lines.Length - 1];
                Regex reg = new Regex(@"\d+(?=\^)|(?<=\^)\d+");
                Match m = reg.Match(s);
                while (m.Success)
                {
                    string num = m.Value;
                    m = m.NextMatch();
                    string pow = m.Value;
                    m = m.NextMatch();
                    if (num!="" && pow!="")
                        s = s.Replace(num + "^" + pow, "Math.Pow(" + num + "," + pow + ")");
                }
                editCalc.AppendText('=' + Calc.Eval(s));
                e.KeyChar = '\n';
            }
        }

        public void SetStateMenu()
        {
            editTestCount.Visible = comboTestType.Enabled = true;
            statusBarTastProgress.Visible = statusBar.Visible = editTestLevel.Visible = editTestCount.Visible = comboRadix.Visible =
                comboTestType.Visible = editCalc.Visible = editSolution.Visible = textTask.Visible = false;
            btnTheory.Visible = btnTestStart.Visible = btnPassExam.Visible = true;
            comboTestType.Font = editTestCount.Font = largeFont;
            comboTestType.SelectedIndex = -1;
            comboRadix.Items.Clear();
            editTestLevel.Value = 3;
            editTestCount.Maximum = 255;
            editTestCount.Value = 12;
        }

        public void SetStateTest()
        {
            statusBarTastProgress.Visible = comboTestType.Visible = editSolution.Visible = textTask.Visible = true;
            if (Reg.Exist)
            {
                if (Reg.ShowCalculator) editCalc.Visible = true;
            }
            else editCalc.Visible = true;
            comboTestType.Font = smallFont;
            editTestCount.Visible = comboTestType.Enabled =
                textComboTestType.Visible = textTestCount.Visible = comboRadix.Visible = editTestLevel.Visible = false;
            
            comboTestType.Left = (SystemInformation.PrimaryMonitorSize.Width - comboTestType.Width) / 2;
            comboTestType.Top = 8;

            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }

        public void ShowTestIni()
        {
            int width = SystemInformation.PrimaryMonitorSize.Width;
            int height = SystemInformation.PrimaryMonitorSize.Height;

            editTestLevel.Left = editTestCount.Left = comboRadix.Left = comboTestType.Left = (width - comboTestType.Width) / 2 + 125;
            comboRadix.Top = (height - comboRadix.Height) / 2;
            editTestLevel.Top = comboRadix.Top + comboRadix.Height + 50;
            comboRadix.Top -= 50;
            comboTestType.Top = comboRadix.Top - comboTestType.Height - 100;
            editTestCount.Top = editTestLevel.Top + editTestLevel.Height + 100;

            btnTheory.Visible = btnTestStart.Visible = btnPassExam.Visible = false;
            statusBar.Visible = comboTestType.Visible = comboRadix.Visible = editTestCount.Visible = editTestLevel.Visible = true;
        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Theory.chm");
        }

        private void теоріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTheory_Click(this, null);
        }

        private void comboTestType_LocationChanged(object sender, EventArgs e)
        {
            textComboTestType.Left = comboTestType.Left;
            textComboTestType.Top = comboTestType.Top - comboTestType.Height;
        }

        private void comboTestType_VisibleChanged(object sender, EventArgs e)
        {
            textComboTestType.Visible = comboTestType.Visible;
        }

        private void comboTestType_FontChanged(object sender, EventArgs e)
        {
            textComboTestType.Font = comboTestType.Font;
            comboTestType.Width = (comboTestType.Font == largeFont) ? 665 : 310;
        }

        private void editTestCount_LocationChanged(object sender, EventArgs e)
        {
            textTestCount.Left = editTestCount.Left;
            textTestCount.Top = editTestCount.Top - editTestCount.Height;
        }

        private void editTestCount_VisibleChanged(object sender, EventArgs e)
        {
            textTestCount.Visible = editTestCount.Visible;
        }

        private void editTestCount_FontChanged(object sender, EventArgs e)
        {
            textTestCount.Font = editTestCount.Font;
        }

        private void comboRadix_VisibleChanged(object sender, EventArgs e)
        {
            textRadix.Visible = comboRadix.Visible;
        }

        private void comboRadix_LocationChanged(object sender, EventArgs e)
        {
            textRadix.Left = comboRadix.Left;
            textRadix.Top = comboRadix.Top - comboRadix.Height;
        }

        private void editTestLevel_VisibleChanged(object sender, EventArgs e)
        {
            textTestLevel.Visible = editTestLevel.Visible;
        }

        private void editTestLevel_LocationChanged(object sender, EventArgs e)
        {
            textTestLevel.Left = editTestLevel.Left;
            textTestLevel.Top = editTestLevel.Top - editTestLevel.Height;
        }

        private void btnTestStart_Click(object sender, EventArgs e)
        {
            task.IsExam = false;
            ShowTestIni();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStateMenu();
        }

        private void comboTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRadix.Items.Clear();
            if (comboTestType.SelectedIndex == 0)
            {
                comboRadix.Items.Add("2 → 8");
                comboRadix.Items.Add("2 → 10");
                comboRadix.Items.Add("2 → 16");
                comboRadix.Items.Add("8 → 2");
                comboRadix.Items.Add("8 → 10");
                comboRadix.Items.Add("8 → 16");
                comboRadix.Items.Add("10 → 2");
                comboRadix.Items.Add("10 → 8");
                comboRadix.Items.Add("10 → 16");
                comboRadix.Items.Add("16 → 2");
                comboRadix.Items.Add("16 → 8");
                comboRadix.Items.Add("16 → 10");
            }
            else
            {
                comboRadix.Items.Add("2");
                comboRadix.Items.Add("8");
                comboRadix.Items.Add("10");
                comboRadix.Items.Add("16");
            }
            editTestLevel.Maximum = 12;
        }

        private void editTestCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (comboTestType.SelectedIndex == -1 || comboRadix.SelectedIndex == -1 ||
                    ((Control)editTestLevel).Text == "" || ((Control)editTestCount).Text == "")
                    MessageBox.Show("Не всі налаштування вибрані");
                else
                {
                    task.SetType(comboTestType.SelectedItem.ToString().Remove(1));
                    editTestLevel_Leave(null, null);
                    task.Count = (byte)editTestCount.Value;
                    task.Level = (byte)editTestLevel.Value;
                    task.Level = (byte)editTestLevel.Value;

                    task.begin = DateTime.Now;
                    task.Good = 0;
                    GenerateTast();
                    statusBarTastProgress.Value = 0;
                    statusBarTastProgress.Maximum = task.Count;
                    r.History.Clear();
                    editSolution.Text = "";
                    editCalc.Text = "";
                    SetStateTest();
                }
        }

        private void btnPassExam_Click(object sender, EventArgs e)
        {
            task.IsExam = true;
            if (pupil == 0) statusBarNameText_Click(null, null);
            else ShowTestIni();
        }

        string SubscriptNumber(byte number)
        {
            string r = "";
            foreach (char d in number.ToString()) r += (char)(d + 8272);
            return r;
        }

        void GenerateTast()
        {
            editSolution.Clear();
            textTask.Text = task.RadixFrom + " → " + task.RadixTo + NewLine + NewLine;
            if (task.Type == TestType.Translate)
            {
                string number = r.Random(task.RadixFrom, task.Level);
                textTask.Text += number + SubscriptNumber(task.RadixFrom) + "=";
                task.CorrectAnswer = Convert.ToString(Convert.ToInt64(number, task.RadixFrom), task.RadixTo);
            }
            else
            {
                string n1str, n2str;
                long n1, n2;
                if (task.Type == TestType.Division)
                {
                    n2str = r.Random(task.RadixFrom, task.Level);
                    n2 = Convert.ToInt64(n2str, task.RadixFrom);
                    n1 = n2 * r.Next(2, (int)Math.Pow(2, task.Level));
                    n1str = Convert.ToString(n1, task.RadixFrom).ToUpper();
                }
                else
                {
                    n1str = r.Random(task.RadixFrom, task.Level);
                    n2str = r.Random(task.RadixFrom, task.Level);
                    n1 = Convert.ToInt64(n1str, task.RadixFrom);
                    n2 = Convert.ToInt64(n2str, task.RadixFrom);
                }
                if ((task.Type == TestType.Substraction || task.Type == TestType.Division) && n2 > n1)
                {
                    long b = n1;
                    n1 = n2;
                    n2 = b;
                    string bs = n1str;
                    n1str = n2str;
                    n2str = bs;
                }
                if (task.Type == TestType.Division)
                {
                    if (task.RadixFrom != 16)
                    {
                        foreach (char c in n1str + SubscriptNumber(task.RadixFrom))
                            textTask.Text += c + char.ConvertFromUtf32(818);
                        textTask.Text += " –––" + NewLine;
                        string space = "";
                        for (byte i = 1; i <= (n1str.Length - n2str.Length); i++) space += " ";
                        byte t = 8;
                        if (task.RadixFrom == 2) t = 4;
                        string s = "";
                        if (task.Level > t) s = " ";
                        textTask.Text += s + space + n2str + SubscriptNumber(task.RadixFrom) + space + " ‾‾‾";
                    }
                    else
                    {
                        textTask.Text += n1str + SubscriptNumber(task.RadixFrom) + (char)TestType.Division + NewLine;
                        textTask.Text += n2str + SubscriptNumber(task.RadixFrom) + '=';
                    }
                }
                else
                {
                    string c1 = "", c2 = "";
                    switch (task.Type)
                    {
                        case TestType.Substraction:
                            c1 = "_"; c2 = " "; break;
                        case TestType.Addition:
                            c1 = " ̟"; c2 = " "; break;
                        case TestType.Multiplication:
                            c1 = " "; c2 = " ̽ "; break;
                    }
                    textTask.Text += c1 + " " + n1str + SubscriptNumber(task.RadixFrom) + NewLine;
                    textTask.Text += c2 + " " + n2str + SubscriptNumber(task.RadixFrom);
                }
                task.CorrectAnswer = Convert.ToString(operations[task.Type](n1, n2), task.RadixTo);
            }
        }

        private void editSolution_KeyUp(object sender, KeyEventArgs e)
        {
            if (editSolution.Text != "" && e.KeyCode == Keys.Enter)
            {
                if (editSolution.Text == task.CorrectAnswer) task.Good++;
                task.Remained--;
                statusBarTastProgress.Value++;
                if (task.Remained == 0)
                {
                    new ResultForm(task.Good, task.Count).ShowDialog();
                    if (task.IsExam) P.Tests.AddRecord(pupil, task.Type, task.Level,
                        task.Count, task.Good, task.begin, DateTime.Now, task.RadixFrom, task.RadixTo);
                    SetStateMenu();
                    return;
                }
                GenerateTast();
            }
        }

        private void statusBarNameText_Click(object sender, EventArgs e)
        {
            SelectPupilForm f = new SelectPupilForm();
            ShowTestIni();
            if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                statusBarFormText.Text = P.Pupils.GetForm(pupil)[1] + "‒" + P.Pupils.GetForm(pupil)[2];
                statusBarNameText.Text = (string)P.Pupils.Select(pupil)[1];
                statusBarSurnameText.Text = (string)P.Pupils.Select(pupil)[2];
            }
            else SetStateMenu();
        }

        private void editTestLevel_Leave(object sender, EventArgs e)
        {
            if (comboRadix.SelectedIndex != -1)
            {
                if (comboRadix.SelectedItem.ToString().Length > 2)
                {
                    task.RadixFrom = Convert.ToByte(comboRadix.SelectedItem.ToString().
                        Remove(comboRadix.SelectedItem.ToString().IndexOf(' ')));
                    task.RadixTo = Convert.ToByte(comboRadix.SelectedItem.ToString().
                        Substring(comboRadix.SelectedItem.ToString().LastIndexOf(' ')));
                }
                else task.RadixFrom = task.RadixTo = Convert.ToByte(comboRadix.SelectedItem.ToString());

                editTestCount.Maximum = (editTestLevel.Value - 1) * task.RadixFrom * (task.RadixFrom - 1);
                if (comboTestType.SelectedIndex > 0) editTestCount.Maximum /= 2;
                if (editTestCount.Maximum > 255) editTestCount.Maximum = 255;
            }
        }

        private void editSolution_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (e.KeyChar == '\b') return;
            char top;
            if (task.RadixTo == 16) top = 'G'; else top = Convert.ToString(task.RadixTo, 16).ToUpper()[0];
            if (e.KeyChar >= '0' && e.KeyChar < top) return;
            e.KeyChar = '\0';
        }

        private void comboRadix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTestType.SelectedIndex == 3 && comboRadix.SelectedIndex!=0)
                editTestLevel.Maximum = 9 - comboRadix.SelectedIndex;
            if (comboTestType.SelectedIndex == 4)
                switch (comboRadix.SelectedIndex)
                {
                    case 0:
                        editTestLevel.Maximum = 6;
                        break;

                    case 1:
                    case 2:
                        editTestLevel.Maximum = 8;
                        break;

                    case 3:
                        editTestLevel.Maximum = 10;
                        break;
                }
            editTestLevel_Leave(null, null);
        }
    }
}