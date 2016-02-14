using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace NumSystem
{
    public struct Reg
    {
        private static readonly string LastLaunchDateStr = "LastLaunchDate";
        private static readonly string ShowCalculatorStr = "ShowCalculator";
        private static readonly string ShowDBstr = "ShowDB";
        private static readonly string PasswordStr = "Password";
        private static readonly string ShowFolderStr = "ShowFolder";

        private static readonly RegistryKey k = Registry.LocalMachine.OpenSubKey("Software\\Numeral system", true);

        public static readonly bool Exist = (k == null) ? false : true;

        public static string LastLaunchDate
        {
            get { return (string)k.GetValue(LastLaunchDateStr); }
            set { k.SetValue(LastLaunchDateStr, value); }
        }

        public static string Password
        {
            get { return (string)k.GetValue(PasswordStr); }
            set { k.SetValue(PasswordStr, value); }
        }

        public static bool ShowCalculator
        {
            get { return Convert.ToBoolean((int)k.GetValue(ShowCalculatorStr)); }
            set { k.SetValue(ShowCalculatorStr, Convert.ToInt32(value)); }
        }

        public static bool ShowDB
        {
            get { return Convert.ToBoolean((int)k.GetValue(ShowDBstr)); }
            set { k.SetValue(ShowDBstr, Convert.ToInt32(value)); }
        }

        public static bool ShowFolder
        {
            get { return Convert.ToBoolean((int)k.GetValue(ShowFolderStr)); }
            set { k.SetValue(ShowFolderStr, Convert.ToInt32(value)); }
        }
    }

    public enum TestType : ushort
    {
        Translate = '→', Addition = '+', Substraction = '−', Multiplication = '×', Division = '÷'
    }

    public struct Task
    {
        public bool IsExam;
        public TestType Type;
        public byte Level;
        public byte Remained;
        private byte _Count;
        public byte Count
        {
            set { Remained = _Count = value; }
            get { return _Count; }
        }
        public byte Good;
        public DateTime begin, end;
        public byte RadixFrom, RadixTo;
        public string CorrectAnswer;
        public override string ToString()
        {
            return ((char)Type).ToString();
        }
        public void SetType(string Type)
        {
            this.Type = (TestType)Convert.ToUInt16(Convert.ToChar(Type));
        }
    }

    class Rnd : Random
    {
        public StringCollection History = new StringCollection();

        public string Random(byte Radix, byte NumberCount)
        {
            string number;
            do
            {
                int fs;
                do fs = this.Next(Radix); while (fs == 0);
                number = Convert.ToString(fs, 16);
                for (byte i = 0; i < NumberCount - 1; i++)
                    number += Convert.ToString(this.Next(Radix), 16);
            }
            while (History.Contains(number));
            History.Add(number);
            return number.ToUpper();
        }
    }

    static class P
    {
        private static OleDbConnection connection;
        private static OleDbDataAdapter FormsDataAdapter, PupilsDataAdapter, TestsDataAdapter;
        public static FormsTable Forms;
        public static PupilsTable Pupils;
        public static TestsTable Tests;
        public static DataSet dSet;
        
        public static readonly string dbFileName = "Pupils.mdb";
        public static readonly string adminCaption = "Системи числення → адміністрування";

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            
            if (args.Length == 1 && args[0] == "c")
            {
                if (Reg.Exist)
                    if (Interaction.InputBox("Введіть пароль", adminCaption) == Reg.Password)
                        Application.Run(new ControlForm());
                    else MessageBox.Show("Пароль не вірний!");
            }
            else
            {
                InitDB();
                Application.Run(new MainForm());
                connection.Close();
            }
        }

        public static void InitDB()
        {
            connection = new OleDbConnection(
                "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + dbFileName + ";");
            // Код, Клас, Літера
            FormsDataAdapter = new OleDbDataAdapter(new OleDbCommand("SELECT * FROM Forms", connection));
            // Код, Ім’я, Прізвище, Пароль, Реєстрація, Клас
            PupilsDataAdapter = new OleDbDataAdapter(new OleDbCommand("SELECT * FROM Pupils", connection));
            // Учень, Тип, Важкість, Кількість, Добре, Початок, Кінець, З_основи, До_основи
            TestsDataAdapter = new OleDbDataAdapter(new OleDbCommand("SELECT * FROM Tests", connection));

            try
            {
                connection.Open();
            }
            catch (OleDbException e)
            {
                MessageBox.Show("Базу данних не знайдено або вона пошкоджена.\n\n" + e.Message,
                    "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }

            dSet = new DataSet();
            Forms = new FormsTable(FormsDataAdapter);
            dSet.Tables.Add(Forms);
            FormsDataAdapter.Fill(Forms);
            Pupils = new PupilsTable(PupilsDataAdapter);
            dSet.Tables.Add(Pupils);
            Pupils.TableName = "Pupils";
            PupilsDataAdapter.Fill(Pupils);
            Tests = new TestsTable(TestsDataAdapter);
            dSet.Tables.Add(Tests);
            Tests.TableName = "Tests";
            TestsDataAdapter.Fill(Tests);

            dSet.Relations.Add("FormsPupils", Forms.Columns[0], Pupils.Columns[5]);
            dSet.Relations.Add("PupilsTests", Pupils.Columns[0], Tests.Columns[0]);
        }

        public static void CloseDB()
        {
            connection.Close();
        }
    }
}