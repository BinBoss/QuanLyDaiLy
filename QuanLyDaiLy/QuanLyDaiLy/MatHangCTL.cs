using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class MatHangCTL
    {
        private MatHangDTO info = new MatHangDTO();
        private MatHangDAO data = new MatHangDAO();

        public MatHangDTO MatHang
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
            data.delete(info.MaMatHang);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsMatHang()
        {
            return data.getDsMatHang();
        }
    }
}
