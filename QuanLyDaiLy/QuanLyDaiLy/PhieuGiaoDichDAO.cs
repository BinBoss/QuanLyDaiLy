using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class PhieuGiaoDichDAO : DataProvider
    {
        public PhieuGiaoDichDAO()
        {
        }

        public ArrayList getDsPhieu()
        {
            connect();
            string query = "SELECT * FROM PhieuGiaoDich";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhieuGiaoDichDTO pgd = new PhieuGiaoDichDTO();
            pgd.MaPhieu = dt.Rows[i]["MaPhieu"].ToString();
            pgd.MaDaiLy = dt.Rows[i]["MaDaiLy"].ToString();
            pgd.NgayLapPhieu = DateTime.Parse(dt.Rows[i]["NgayLapPhieu"].ToString());
            pgd.LoaiPhieu = dt.Rows[i]["LoaiPhieu"].ToString();

            return (object)pgd;
        }

        public void insert(PhieuGiaoDichDTO info)
        {
            string insertCommand = "INSERT INTO PhieuGiaoDich VALUES('" +
                info.MaPhieu + "', '" +
                info.MaDaiLy + "', '" +
                info.NgayLapPhieu + "', '" +
                info.LoaiPhieu + ")";

            executeNonQuery(insertCommand);
        }

        public void update(PhieuGiaoDichDTO info)
        {
            string updateCommand = "UPDATE PhieuGiaoDich " +
                                    "SET MaDaiLy = '" + info.MaDaiLy + "', " +
                                    " NgayLapPhieu = '" + info.NgayLapPhieu + "', " +
                                    " LoaiPhieu = '" + info.LoaiPhieu + "', " +
                                    " WHERE MaPhieu = '" + info.MaPhieu + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maPhieu)
        {
            string deleteCommand = "DELETE FROM PhieuGiaoDich WHERE MaPhieu = '" + maPhieu + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
