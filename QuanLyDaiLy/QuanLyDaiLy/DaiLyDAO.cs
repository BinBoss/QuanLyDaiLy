using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
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
            string query = "SELECT * FROM DAILY";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        //public HocSinhDTO[] getDsHocSinh()
        //{
        //    connect();
        //    string query = "SELECT * FROM HOCSINH";
        //    adapter = new OleDbDataAdapter(query, connection);
        //    DataSet dataset = new DataSet();
        //    adapter.Fill(dataset);
        //    HocSinhDTO[] arr;

        //    DataTable dt = dataset.Tables[0];
        //    int i, n = dt.Rows.Count;
        //    arr = new HocSinhDTO[n];
        //    for (i = 0; i < n; i++)
        //    {
        //        object hs = GetDataFromDataRow(dt, i);
        //        arr[i] = (HocSinhDTO)hs;
        //    }
        //    return arr;
        //}

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
            string insertCommand = "INSERT INTO HOCSINH VALUES('" +
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
            string updateCommand = "UPDATE DAILY " +
                                    "SET TenDL = '" + info.TenDL + "', " +
                                    " DiaChi = '" + info.DiaChi + "', " +
                                    " MaLoaiDL = '" + info.MaLoaiDL + "', " +
                                    " NgayTiepNhan = '" + info.NgayTiepNhan.ToShortDateString() + "', " +
                                    " MaQuan = '" + info.MaQuan + "'," +
                                    " Email = '" + info.Email + "', " +
                                    " SDT = " + info.SDT +
                                    " WHERE MaHocSinh = '" + info.MaDL + "'";


            executeNonQuery(updateCommand);
        }

        public void delete(string maDL)
        {
            string deleteCommand = "DELETE FROM DAILY WHERE MaDL = '" + maDL + "'";
            executeNonQuery(deleteCommand);
        }
        
    }
}
