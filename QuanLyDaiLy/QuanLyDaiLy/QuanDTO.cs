using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class QuanDTO
    {
        private string _maQuan;
        private int _soDaiLyToiDa;
        private string _tenQuan;

        public string TenQuan
        {
            get { return _tenQuan; }
            set { _tenQuan = value; }
        }

        public int SoDaiLyToiDa
        {
            get { return _soDaiLyToiDa; }
            set { _soDaiLyToiDa = value; }
        }
        public string MaQuan
        {
            get { return _maQuan; }
            set { _maQuan = value; }
        }
    }
}
