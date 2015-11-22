using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class PhieuXuatHangCTL
    {
        private PhieuXuatHangDTO info = new PhieuXuatHangDTO();
        private PhieuXuatHangDAO data = new PhieuXuatHangDAO();

        public PhieuXuatHangDTO PhieuXuatHang
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
            data.delete(info.MaPhieuXuatHang);
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
