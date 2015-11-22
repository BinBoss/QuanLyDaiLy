using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;


namespace QuanLyDaiLy
{
    class PhieuXuatHangDAO : DataProvider
    {
        public PhieuXuatHangDAO()
        {
        }

        public ArrayList getDsPhieu()
        {
            connect();
            string query = "SELECT * FROM PhieuXuatHang";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhieuXuatHangDTO ptt = new PhieuXuatHangDTO();
            ptt.MaPhieuXuatHang = dt.Rows[i]["MaPhieu"].ToString();
            ptt.TongTienXuat = int.Parse(dt.Rows[i]["TongTienXuat"].ToString());

            return (object)ptt;
        }

        public void insert(PhieuXuatHangDTO info)
        {
            string insertCommand = "INSERT INTO PhieuXuatHang VALUES('" +
                info.MaPhieuXuatHang + "', '" +
                info.TongTienXuat + ")";

            executeNonQuery(insertCommand);
        }

        public void update(PhieuXuatHangDTO info)
        {
            string updateCommand = "UPDATE PhieuXuatHang " +
                                    "SET TongTienXuat = '" + info.TongTienXuat + "', " +
                                    " WHERE MaPhieu = '" + info.MaPhieuXuatHang + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maPhieu)
        {
            string deleteCommand = "DELETE FROM PhieuXuatHang WHERE MaPhieu = '" + maPhieu + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
