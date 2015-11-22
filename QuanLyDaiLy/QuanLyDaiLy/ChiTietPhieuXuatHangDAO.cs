using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class ChiTietPhieuXuatHangDAO : DataProvider
    {
        public ChiTietPhieuXuatHangDAO()
        {
        }

        public ArrayList getDsChiTiet()
        {
            connect();
            string query = "SELECT * FROM ChiTietPhieuXuatHang";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            ChiTietPhieuXuatHangDTO ctpxh = new ChiTietPhieuXuatHangDTO();
            ctpxh.MaChiTietPhieuXuatHang = dt.Rows[i]["MaChiTietPhieuXuatHang"].ToString();
            ctpxh.MaPhieuXuatHang = dt.Rows[i]["MaPhieuXuatHang"].ToString();
            ctpxh.MaMatHang = dt.Rows[i]["MaMatHang"].ToString();
            ctpxh.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

            return (object)ctpxh;
        }

        public void insert(ChiTietPhieuXuatHangDTO info)
        {
            string insertCommand = "INSERT INTO ChiTietPhieuXuatHang VALUES('" +
                info.MaChiTietPhieuXuatHang + "', '" +
                info.MaPhieuXuatHang + "', '" +
                info.MaMatHang + "', '" +
                info.SoLuong + ")";

            executeNonQuery(insertCommand);
        }

        public void update(ChiTietPhieuXuatHangDTO info)
        {
            string updateCommand = "UPDATE ChiTietPhieuXuatHang " +
                                    "SET MaPhieuXuat = '" + info.MaPhieuXuatHang + "', " +
                                    " MatHang = '" + info.MaMatHang + "', " +
                                    " SoLuongHang = '" + info.SoLuong +
                                    " WHERE MaChiTiet = '" + info.MaChiTietPhieuXuatHang + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maChiTiet)
        {
            string deleteCommand = "DELETE FROM ChiTietPhieuXuatHang WHERE MaChiTiet = '" + maChiTiet + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
