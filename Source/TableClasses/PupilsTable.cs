using System;
using System.Data;
using System.Data.OleDb;

namespace NumSystem
{
    public class PupilsTable : DataTable
    {
        private OleDbDataAdapter adapter;

        public DataRow AddRecord(byte Клас, string Імя, string Прізвище, string Пароль, DateTime Реєстрація)
        {
            DataRow row = Select(Клас, Імя, Прізвище);
            if (row == null)
            {
                ushort code = 0;
                if (Rows.Count != 0) code = (ushort)(Convert.ToUInt16(Rows[Rows.Count - 1][0]) + 1);
                Rows.Add(code, Імя, Прізвище, Пароль, Реєстрація, Клас);
                adapter.Update(this);
                return Rows[Rows.Count-1];
            }
            else return row;
        }

        public DataRow Select(ushort Код)
        {
            DataRow[] eRow = Select(string.Format("Код={0}", Код));
            if (eRow.Length != 0) return eRow[0];
            return null;
        }

        public DataRow Select(byte Клас, string Імя, string Прізвище)
        {
            DataRow[] eRow = Select(string.Format("Клас={0} AND Ім’я='{1}' AND Прізвище='{2}'", Клас, Імя, Прізвище));
            if (eRow.Length != 0) return eRow[0];
            return null;
        }

        public DataRow[] GetTestsRows(byte Клас, string Імя, string Прізвище)
        {
            DataRow row = Select(Клас, Імя, Прізвище);
            if (row != null) return row.GetChildRows(P.dSet.Relations["PupilsTests"]);
            return null;
        }

        public ushort GetCode(byte Клас, string Імя, string Прізвище)
        {
            DataRow row = Select(Клас, Імя, Прізвище);
            if (row != null) return Convert.ToUInt16(row[0]);
            return 0;
        }

        public DataRow GetForm(ushort Код)
        {
            DataRow r = Select(Код);
            if (r != null) return P.Forms.Select(Convert.ToByte(r[5]));
            return null;
        }

        public PupilsTable(OleDbDataAdapter adapter)
        {
            this.adapter = adapter;

            adapter.UpdateCommand = new OleDbCommandBuilder(adapter).GetUpdateCommand();
            this.RowChanged += new DataRowChangeEventHandler(AcceptChanges);

            adapter.InsertCommand = new OleDbCommandBuilder(adapter).GetInsertCommand();

            adapter.DeleteCommand = new OleDbCommandBuilder(adapter).GetDeleteCommand();
            this.RowDeleted +=new DataRowChangeEventHandler(AcceptChanges);
        }

        private void AcceptChanges(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Change || e.Action == DataRowAction.Delete)
            {
                adapter.Update(this);
            }
        }
    }
}