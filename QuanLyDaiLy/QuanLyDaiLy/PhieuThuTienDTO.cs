using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class PhieuThuTienDTO
    {
        private string _maPhieuThuTien;
        private int _soTienThu;

        public string MaPhieuThuTien
        {
            get { return _maPhieuThuTien; }
            set { _maPhieuThuTien = value; }
        }

        public int SoTienThu
        {
            get { return _soTienThu; }
            set { _soTienThu = value; }
        }
    }
}
