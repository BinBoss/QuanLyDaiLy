using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class DoanhSoDaiLyDTO
    {
        private string _maBaoCao;
        private string _maDaiLy;
        private int _soPhieuXuatHang;
        private int _tongGiaTri;
        private DateTime _thoiGian;

        public string MaBaoCao
        {
            get { return _maBaoCao; }
            set { _maBaoCao = value; }
        }

        public string MaDaiLy
        {
            get { return _maDaiLy; }
            set { _maDaiLy = value; }
        }

        public int SoPhieuXuat
        {
            get { return _soPhieuXuatHang; }
            set { _soPhieuXuatHang = value; }
        }

        public int TongGiaTri
        {
            get { return _tongGiaTri; }
            set { _tongGiaTri = value; }
        }

        public DateTime ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }
    }
}
