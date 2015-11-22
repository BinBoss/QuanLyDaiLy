using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class TaiKhoanDAO : DataProvider
    {
        public TaiKhoanDAO()
        {
        }

        public ArrayList getDsTaiKhoan()
        {
            connect();
            string query = "SELECT * FROM TaiKhoan";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
            tk.MatKhau = dt.Rows[i]["MatKhau"].ToString();
            tk.QuyenTruyCap = dt.Rows[i]["QuyenTruyCap"].ToString();

            return (object)tk;
        }

        public void insert(TaiKhoanDTO info)
        {
            string insertCommand = "INSERT INTO TaiKhoan VALUES('" +
                info.TenDangNhap + "', '" +
                info.MatKhau + "', '" +
                info.QuyenTruyCap + ")";

            executeNonQuery(insertCommand);
        }

        public void update(TaiKhoanDTO info)
        {
            string updateCommand = "UPDATE TaiKhoan " +
                                    "SET MatKhau = '" + info.MatKhau + "', " +
                                    " QuyenTruyCap = '" + info.QuyenTruyCap + "', " +
                                    " WHERE TenDangNhap = '" + info.TenDangNhap + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string tenDangNhap)
        {
            string deleteCommand = "DELETE FROM TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
