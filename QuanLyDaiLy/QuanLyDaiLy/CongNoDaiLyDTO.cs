using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class CongNoDaiLyDTO
    {
        private string _maBaoCao;
        private string _maDaiLy;
        private int _noDau;
        private int _noCuoi;
        private int _phatSinh;
        private int _soNoDaTra;
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

        public int NoDau
        {
            get { return _noDau; }
            set { _noDau = value; }
        }

        public int NoCuoi
        {
            get { return _noCuoi; }
            set { _noCuoi = value; }
        }

        public int PhatSinh
        {
            get { return _phatSinh; }
            set { _phatSinh = value; }
        }
        public int SoNoDaTra
        {
            get { return _soNoDaTra; }
            set { _soNoDaTra = value; }
        }
        public DateTime ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }
    }
}
