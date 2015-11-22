using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class QuanDAO : DataProvider
    {
        public QuanDAO()
        {
        }

        public ArrayList getDsQuan()
        {
            connect();
            string query = "SELECT * FROM Quan";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            QuanDTO quan = new QuanDTO();
            quan.MaQuan = dt.Rows[i]["MaQuan"].ToString();
            quan.TenQuan = dt.Rows[i]["TenQuan"].ToString();
            quan.SoDaiLyToiDa = int.Parse(dt.Rows[i]["SoDaiLyToiDa"].ToString());

            return (object)quan;
        }

        public void insert(QuanDTO info)
        {
            string insertCommand = "INSERT INTO Quan VALUES('" +
                info.MaQuan + "', '" +
                info.TenQuan + "', '" +
                info.SoDaiLyToiDa + ")";

            executeNonQuery(insertCommand);
        }

        public void update(QuanDTO info)
        {
            string updateCommand = "UPDATE Quan " +
                                    "SET TenQuan = '" + info.TenQuan + "', " +
                                    "SoDaiLyToiDa = '" + info.SoDaiLyToiDa + "', " +
                                    " WHERE MaQuan = '" + info.MaQuan + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maQuan)
        {
            string deleteCommand = "DELETE FROM Quan WHERE MaQuan = '" + maQuan + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
