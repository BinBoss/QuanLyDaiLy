using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class ChiTietPhieuXuatHangDTO
    {
        private string _maChiTietPXH;
        private string _maPhieuXuatHang;
        private string _maMatHang;
        private int _soLuong;

        public string MaChiTietPhieuXuatHang
        {
            get { return _maChiTietPXH; }
            set { _maChiTietPXH = value; }
        }

        public string MaPhieuXuatHang
        {
            get { return _maPhieuXuatHang; }
            set { _maPhieuXuatHang = value; }
        }

        public string MaMatHang
        {
            get { return _maMatHang; }
            set { _maMatHang = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
