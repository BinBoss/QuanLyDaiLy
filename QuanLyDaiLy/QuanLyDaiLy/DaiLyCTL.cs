using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class DaiLyCTL
    {
        private DaiLyDTO info = new DaiLyDTO();
        private DaiLyDAO data = new DaiLyDAO();

        public DaiLyDTO DaiLy
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
            data.delete(info.MaDL);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsDaiLy()
        {
            return data.getDsDaiLy();
        }
    }
}
