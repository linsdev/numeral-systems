using System;
using System.Data;
using System.Data.OleDb;

namespace NumSystem
{
    class TestsTable : DataTable
    {
        OleDbDataAdapter adapter;

        public void AddRecord(ushort Учень, TestType Тип, byte Важкість, byte Кількість, byte Добре,
            DateTime Початок, DateTime Кінець, byte З_основи, byte До_основи)
        {
            Rows.Add(Учень, (char)Тип, Важкість, Кількість, Добре, Початок, Кінець, З_основи, До_основи);
            adapter.Update(this);
        }

        public TestsTable(OleDbDataAdapter adapter)
        {
            this.adapter = adapter;

            adapter.InsertCommand = new OleDbCommandBuilder(adapter).GetInsertCommand();

            adapter.DeleteCommand = new OleDbCommand(
                "DELETE FROM Tests WHERE Учень=? AND Початок=? AND Кінець=?", adapter.SelectCommand.Connection);
            adapter.DeleteCommand.Parameters.Add("", OleDbType.BSTR, 32, "Учень");
            adapter.DeleteCommand.Parameters.Add("", OleDbType.Date, 4, "Початок");
            adapter.DeleteCommand.Parameters.Add("", OleDbType.Date, 4, "Кінець");
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