using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class MatHangDAO : DataProvider
    {
        public MatHangDAO()
        {
        }

        public ArrayList getDsMatHang()
        {
            connect();
            string query = "SELECT * FROM MatHang";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            MatHangDTO mh = new MatHangDTO();
            mh.MaMatHang = dt.Rows[i]["MaMatHang"].ToString();
            mh.TenMatHang = dt.Rows[i]["TenMatHang"].ToString();
            mh.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
            mh.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());

            return (object)mh;
        }

        public void insert(MatHangDTO info)
        {
            string insertCommand = "INSERT INTO MatHang VALUES('" +
                info.MaMatHang + "', '" +
                info.TenMatHang + "', '" +
                info.DonViTinh + "', '" +
                info.DonGia + ")";

            executeNonQuery(insertCommand);
        }

        public void update(MatHangDTO info)
        {
            string updateCommand = "UPDATE MatHang " +
                                    "SET TenMatHang = '" + info.TenMatHang + "', " +
                                    " DonViTinh = '" + info.DonViTinh + "', " +
                                    " DonGia = '" + info.DonGia + "', " +
                                    " WHERE MaMatHang = '" + info.MaMatHang + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maMatHang)
        {
            string deleteCommand = "DELETE FROM MatHang WHERE MaMatHang = '" + maMatHang + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
