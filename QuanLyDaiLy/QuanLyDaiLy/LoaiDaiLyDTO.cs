using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class LoaiDaiLyDTO
    {
        private string _maLoaiDaiLy;
        private string _tenLoaiDaiLy;

        public string MaLoaiDaiLy
        {
            get { return _maLoaiDaiLy; }
            set { _maLoaiDaiLy = value; }
        }

        public string TenLoaiDaiLy
        {
            get { return _tenLoaiDaiLy; }
            set { _tenLoaiDaiLy = value; }
        }
    }
}
