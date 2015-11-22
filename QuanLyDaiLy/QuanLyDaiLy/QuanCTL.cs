using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class QuanCTL
    {
        private QuanDTO info = new QuanDTO();
        private QuanDAO data = new QuanDAO();

        public QuanDTO Quan
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
            data.delete(info.MaQuan);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsQuan()
        {
            return data.getDsQuan();
        }
    }
}
