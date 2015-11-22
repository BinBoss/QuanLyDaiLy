using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class DoanhSoDaiLyCTL
    {
        private DoanhSoDaiLyDTO info = new DoanhSoDaiLyDTO();
        private DoanhSoDaiLyDAO data = new DoanhSoDaiLyDAO();

        public DoanhSoDaiLyDTO DoanhSoDaiLy
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
            data.delete(info.MaBaoCao);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsDoanhSo()
        {
            return data.getDsDoanhSo();
        }
    }
}
