using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class PhieuXuatHangDTO
    {
        private string _maPhieuXuatHang;
        private int _tongTienXuat;

        public string MaPhieuXuatHang
        {
            get { return _maPhieuXuatHang; }
            set { _maPhieuXuatHang = value; }
        }

        public int TongTienXuat
        {
            get { return _tongTienXuat; }
            set { _tongTienXuat = value; }
        }

    }
}
