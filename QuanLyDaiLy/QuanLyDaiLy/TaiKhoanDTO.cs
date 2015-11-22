using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class TaiKhoanDTO
    {
        private string _tenDangNhap;
        private string _matKhau;
        private string _quyenTruyCap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        public string QuyenTruyCap
        {
            get { return _quyenTruyCap; }
            set { _quyenTruyCap = value; }
        }
    }
}
