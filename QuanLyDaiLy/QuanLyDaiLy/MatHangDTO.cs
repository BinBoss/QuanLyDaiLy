﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    class MatHangDTO
    {
        private string _maMatHang;
        private string _tenMatHang;
        private int _donGia;
        private string _donViTinh;

        public string MaMatHang
        {
            get { return _maMatHang; }
            set { _maMatHang = value; }
        }

        public string TenMatHang
        {
            get { return _tenMatHang; }
            set { _tenMatHang = value; }
        }

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        public string DonViTinh
        {
            get { return _donViTinh; }
            set { _donViTinh = value; }
        }
    }
}
