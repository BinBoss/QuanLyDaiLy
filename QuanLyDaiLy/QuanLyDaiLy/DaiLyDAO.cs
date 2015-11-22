using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy 
{
    public class DaiLyDAO : DataProvider
    {
        
        public DaiLyDAO()
        {
        }

        public ArrayList getDsDaiLy()
        {
            connect();
            string query = "SELECT * FROM DaiLy";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            DaiLyDTO dl = new DaiLyDTO();
            dl.MaDL = dt.Rows[i]["MaDaiLy"].ToString();
            dl.TenDL = dt.Rows[i]["TenDaiLy"].ToString();
            dl.MaLoaiDL = dt.Rows[i]["MaLoaiDaiLy"].ToString();
            dl.DiaChi = dt.Rows[i]["DiaChi"].ToString();
            dl.SDT = dt.Rows[i]["DienThoai"].ToString();
            dl.Email = dt.Rows[i]["Email"].ToString();
            dl.MaQuan = dt.Rows[i]["MaQuan"].ToString();
            dl.NgayTiepNhan = DateTime.Parse(dt.Rows[i]["NgayTiepNhan"].ToString());
            
            return (object)dl;
        }

        public void insert(DaiLyDTO info)
        {
            string insertCommand = "INSERT INTO DaiLy VALUES('" +
                info.MaDL + "', '" +
                info.TenDL + "', '" +
                info.MaLoaiDL + "', '" +
                info.DiaChi + "', '" +
                info.SDT + "'," +
                info.Email + "', '" +
                info.MaQuan + "'," +
                info.NgayTiepNhan.ToShortDateString() + ")";
               
            executeNonQuery(insertCommand);
        }

        public void update(DaiLyDTO info)
        {
            string updateCommand = "UPDATE DaiLy " +
                                    "SET TenDaiLy = '" + info.TenDL + "', " +
                                    " LoaiDaiLy = '" + info.MaLoaiDL + "', " +
                                    " SDT = " + info.SDT +
                                    " Email = '" + info.Email + "', " +
                                    " DiaChi = '" + info.DiaChi + "', " +
                                    " Quan = '" + info.MaQuan + "'," +
                                    " NgayTiepNhan = '" + info.NgayTiepNhan.ToShortDateString() + "', " +
                                    " WHERE MaDaiLy = '" + info.MaDL + "'";


            executeNonQuery(updateCommand);
        }

        public void delete(string maDL)
        {
            string deleteCommand = "DELETE FROM DaiLy WHERE MaDL = '" + maDL + "'";
            executeNonQuery(deleteCommand);
        }
        
    }
}
