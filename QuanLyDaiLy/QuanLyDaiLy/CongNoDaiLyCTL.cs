using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class CongNoDaiLyCTL
    {
        private CongNoDaiLyDTO info = new CongNoDaiLyDTO();
        private CongNoDaiLyDAO data = new CongNoDaiLyDAO();

        public CongNoDaiLyDTO CongNoDaiLy
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public void insert()
        {
            data.insert(info);
        }

        public void delete()
        {
            data.delete(info.MaBaoCao);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsCongNo()
        {
            return data.getDsCongNo();
        }
    }
}
