using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class PhieuGiaoDichDTO
    {
        private string _maPhieu;
        private string _maDL;
        private DateTime _ngayLapPhieu;
        private string _loaiPhieu;

        public string MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        public string LoaiPhieu
        {
            get { return _loaiPhieu; }
            set { _loaiPhieu = value; }
        }

        public string MaDaiLy
        {
            get { return _maDL; }
            set { _maDL = value; }
        }
        public DateTime NgayLapPhieu
        {
            get { return _ngayLapPhieu; }
            set { _ngayLapPhieu = value; }
        }
    }
}
