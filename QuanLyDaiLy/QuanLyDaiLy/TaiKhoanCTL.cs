using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class TaiKhoanCTL
    {
        private TaiKhoanDTO info = new TaiKhoanDTO();
        private TaiKhoanDAO data = new TaiKhoanDAO();

        public TaiKhoanDTO TaiKhoan
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public void insert()
        {
            data.insert(info);
        }

        public void delete()
        {
            data.delete(info.TenDangNhap);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsTaiKhoan()
        {
            return data.getDsTaiKhoan();
        }
    }
}
