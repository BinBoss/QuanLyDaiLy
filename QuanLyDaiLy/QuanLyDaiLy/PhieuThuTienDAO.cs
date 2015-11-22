using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class PhieuThuTienDAO : DataProvider
    {
        public PhieuThuTienDAO()
        {
        }

        public ArrayList getDsPhieu()
        {
            connect();
            string query = "SELECT * FROM PhieuThuTien";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhieuThuTienDTO ptt = new PhieuThuTienDTO();
            ptt.MaPhieuThuTien = dt.Rows[i]["MaPhieu"].ToString();
            ptt.SoTienThu = int.Parse(dt.Rows[i]["SoTienThu"].ToString());

            return (object)ptt;
        }

        public void insert(PhieuThuTienDTO info)
        {
            string insertCommand = "INSERT INTO PhieuThuTien VALUES('" +
                info.MaPhieuThuTien + "', '" +
                info.SoTienThu + ")";

            executeNonQuery(insertCommand);
        }

        public void update(PhieuThuTienDTO info)
        {
            string updateCommand = "UPDATE PhieuThuTien " +
                                    "SET SoTienThu = '" + info.SoTienThu + "', " +
                                    " WHERE MaPhieu = '" + info.MaPhieuThuTien + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maPhieu)
        {
            string deleteCommand = "DELETE FROM PhieuThuTien WHERE MaPhieu = '" + maPhieu + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
