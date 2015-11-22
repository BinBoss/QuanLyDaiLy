using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class DoanhSoDaiLyDAO :DataProvider
    {
        public DoanhSoDaiLyDAO()
        {
        }

        public ArrayList getDsDoanhSo()
        {
            connect();
            string query = "SELECT * FROM BaoCaoDoanhSo";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            DoanhSoDaiLyDTO dsdl = new DoanhSoDaiLyDTO();
            dsdl.MaBaoCao = dt.Rows[i]["MaBaoCao"].ToString();
            dsdl.MaDaiLy = dt.Rows[i]["MaDaiLy"].ToString();
            dsdl.Thang = DateTime.Parse(dt.Rows[i]["Thang"].ToString());
            dsdl.SoPhieuXuat = int.Parse(dt.Rows[i]["SoPhieuXuat"].ToString());
            dsdl.TongGiaTri = int.Parse(dt.Rows[i]["TongGiaTri"].ToString());

            return (object)dsdl;
        }

        public void insert(DoanhSoDaiLyDTO info)
        {
            string insertCommand = "INSERT INTO BaoCaoDoanhSo VALUES('" +
                info.MaBaoCao + "', '" +
                info.MaDaiLy + "', '" +
                info.Thang + "', '" +
                info.SoPhieuXuat + "', '" +
                info.TongGiaTri + ")";

            executeNonQuery(insertCommand);
        }

        public void update(DoanhSoDaiLyDTO info)
        {
            string updateCommand = "UPDATE BaoCaoDoanhSo " +
                                    "SET MaDaiLy = '" + info.MaDaiLy + "', " +
                                    " Thang = '" + info.Thang + "', " +
                                    " SoPhieuXuat = '" + info.SoPhieuXuat + "', " +
                                    " TongGiaTri = '" + info.TongGiaTri + "', " +
                                    " WHERE MaBaoCao = '" + info.MaBaoCao + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maBaoCao)
        {
            string deleteCommand = "DELETE FROM BaoCaoDoanhSo WHERE MaBaoCao = '" + maBaoCao + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
