using System;
using System.Data;
using System.Data.OleDb;

namespace NumSystem
{
    public class FormsTable : DataTable
    {
        private OleDbDataAdapter adapter;

        public byte AddRecord(string Клас, string Літера)
        {
            byte Class = Convert.ToByte(Клас);
            DataRow eRow = Select(Клас, Літера);
            if (eRow == null)
            {
                byte code = 0;
                if (Rows.Count != 0) code = (byte)((int)Rows[Rows.Count - 1][0] + 1);
                Rows.Add(code, Class, Літера);
                adapter.Update(this);
                return Convert.ToByte(Rows[Rows.Count-1][0]);
            }
            else return Convert.ToByte(eRow[0]);
        }

        public DataRow Select(byte Код)
        {
            DataRow[] eRows = Select("Код=" + Код);
            if (eRows.Length != 0) return eRows[0];
            return null;
        }

        public new DataRow Select(string Клас, string Літера)
        {
            DataRow[] eRows = Select(string.Format("Клас={0} AND Літера='{1}'", Клас, Літера));
            if (eRows.Length != 0) return eRows[0];
            return null;
        }

        public DataRow[] GetPupilsRows(byte Код)
        {
            DataRow row = Select(Код);
            if (row != null) return row.GetChildRows(P.dSet.Relations["FormsPupils"]);
            return null;
        }
        
        public byte GetCode(string Клас, string Літера)
        {
            DataRow row = Select(Клас, Літера);
            if (row != null) return Convert.ToByte(row[0]);
            return 0;
        }

        public FormsTable(OleDbDataAdapter adapter)
        {
            this.adapter = adapter;

            adapter.UpdateCommand = new OleDbCommandBuilder(adapter).GetUpdateCommand();
            this.RowChanged += new DataRowChangeEventHandler(AcceptChanges);

            adapter.InsertCommand = new OleDbCommandBuilder(adapter).GetInsertCommand();

            adapter.DeleteCommand = new OleDbCommandBuilder(adapter).GetDeleteCommand();
            this.RowDeleted += new DataRowChangeEventHandler(AcceptChanges);
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