using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class ChiTietPhieuXuatHangCTL
    {
        private ChiTietPhieuXuatHangDTO info = new ChiTietPhieuXuatHangDTO();
        private ChiTietPhieuXuatHangDAO data = new ChiTietPhieuXuatHangDAO();

        public ChiTietPhieuXuatHangDTO ChiTietPhieuXuatHang
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
            data.delete(info.MaChiTietPhieuXuatHang);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsChiTiet()
        {
            return data.getDsChiTiet();
        }
    }
}
