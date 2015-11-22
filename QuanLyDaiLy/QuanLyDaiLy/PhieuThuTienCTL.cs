using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class PhieuThuTienCTL
    {
        private PhieuThuTienDTO info = new PhieuThuTienDTO();
        private PhieuThuTienDAO data = new PhieuThuTienDAO();

        public PhieuThuTienDTO PhieuThuTien
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
            data.delete(info.MaPhieuThuTien);
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
