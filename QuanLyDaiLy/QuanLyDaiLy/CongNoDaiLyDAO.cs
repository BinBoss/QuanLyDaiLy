using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace QuanLyDaiLy
{
    class CongNoDaiLyDAO : DataProvider
    {
        public CongNoDaiLyDAO()
        {
        }

        public ArrayList getDsCongNo()
        {
            connect();
            string query = "SELECT * FROM BaoCaoCongNo";
            adapter = new OleDbDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);

            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            CongNoDaiLyDTO cndl = new CongNoDaiLyDTO();
            cndl.MaBaoCao = dt.Rows[i]["MaBaoCao"].ToString();
            cndl.MaDaiLy = dt.Rows[i]["MaDaiLy"].ToString();
            cndl.Thang = DateTime.Parse(dt.Rows[i]["Thang"].ToString());
            cndl.NoDau = int.Parse(dt.Rows[i]["NoDau"].ToString());
            cndl.PhatSinh = int.Parse(dt.Rows[i]["PhatSinh"].ToString());
            cndl.NoCuoi = int.Parse(dt.Rows[i]["NoCuoi"].ToString());

            return (object)cndl;
        }

        public void insert(CongNoDaiLyDTO info)
        {
            string insertCommand = "INSERT INTO BaoCaoCongNo VALUES('" +
                info.MaBaoCao + "', '" +
                info.MaDaiLy + "', '" +
                info.Thang + "', '" +
                info.NoDau + "', '" +
                info.PhatSinh + "', '" +
                info.NoCuoi + ")";

            executeNonQuery(insertCommand);
        }

        public void update(CongNoDaiLyDTO info)
        {
            string updateCommand = "UPDATE BaoCaoCongNo " +
                                    "SET MaDaiLy = '" + info.MaDaiLy + "', " +
                                    " Thang = '" + info.Thang + "', " +
                                    " NoDau = '" + info.NoDau + "', " +
                                    " PhatSinh = '" + info.PhatSinh + "', " +
                                    " NoCuoi = '" + info.NoCuoi +
                                    " WHERE MaBaoCao = '" + info.MaBaoCao + "'";

            executeNonQuery(updateCommand);
        }

        public void delete(string maBaoCao)
        {
            string deleteCommand = "DELETE FROM BaoCaoCongNo WHERE MaBaoCao = '" + maBaoCao + "'";
            executeNonQuery(deleteCommand);
        }
    }
}
