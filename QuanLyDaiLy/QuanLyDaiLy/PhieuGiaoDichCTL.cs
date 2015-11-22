using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class PhieuGiaoDichCTL
    {
        private PhieuGiaoDichDTO info = new PhieuGiaoDichDTO();
        private PhieuGiaoDichDAO data = new PhieuGiaoDichDAO();

        public PhieuGiaoDichDTO PhieuGiaoDich
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
            data.delete(info.MaPhieu);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsPhieu()
        {
            return data.getDsPhieu();
        }
    }
}
