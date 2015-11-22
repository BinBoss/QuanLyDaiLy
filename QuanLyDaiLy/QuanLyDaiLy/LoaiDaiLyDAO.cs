using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class LoaiDaiLyDAO : DataProvider
    {
        public LoaiDaiLyDAO()
        {
        }

        public ArrayList getDsLoaiDaiLy()
        {
            connect();
            string query = "SELECT * FROM LoaiDaiLy";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            LoaiDaiLyDTO loai = new LoaiDaiLyDTO();
            loai.MaLoaiDaiLy = dt.Rows[i]["MaLoai"].ToString();
            loai.TenLoaiDaiLy = dt.Rows[i]["TenLoai"].ToString();
            loai.SoTienNoToiDa = int.Parse(dt.Rows[i]["SoTienNoToiDa"].ToString());

            return (object)loai;
        }

        public void insert(LoaiDaiLyDTO info)
        {
            string insertCommand = "INSERT INTO LoaiDaiLy VALUES('" +
                info.MaLoaiDaiLy + "', '" +
                info.TenLoaiDaiLy + "', '" +
                info.SoTienNoToiDa + ")";

            executeNonQuery(insertCommand);
        }

        public void update(LoaiDaiLyDTO info)
        {
            string updateCommand = "UPDATE LoaiDaiLy " +
                                    "SET TenLoai = '" + info.TenLoaiDaiLy + "', " +
                                    " SoTienNoToiDa = '" + info.SoTienNoToiDa + "', " +
                                    " WHERE MaLoai = '" + info.MaLoaiDaiLy + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maLoai)
        {
            string deleteCommand = "DELETE FROM LoaiDaiLy WHERE MaLoai = '" + maLoai + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
