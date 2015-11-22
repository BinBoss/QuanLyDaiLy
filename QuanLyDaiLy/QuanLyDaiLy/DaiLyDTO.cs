using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    public class DaiLyDTO
    {
        private string _maDL;
        private string _maLoaiDL;
        private string _tenDL;
        private string _diachi;
        private string _sdt;
        private string _email;
        private string _maQuan;
        private DateTime _ngaytiepnhan;

        public string MaDL
        {
            get { return _maDL; }
            set
            {
                if (value == null)
                    throw new Exception("Ma HS khong duoc rong");
                _maDL = value;
            }
        }

        public string TenDL
        {
            get { return _tenDL; }
            set { _tenDL = value; }
        }

        public DateTime NgayTiepNhan
        {
            get { return _ngaytiepnhan; }
            set { _ngaytiepnhan = value; }
        }

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        public string MaQuan
        {
            get { return _maQuan; }
            set { _maQuan = value; }
        }

        public string MaLoaiDL
        {
            get { return _maLoaiDL; }
            set { _maLoaiDL = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
    }
}
