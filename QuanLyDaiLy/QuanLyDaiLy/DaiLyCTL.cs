using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace QuanLyDaiLy
{
    class DaiLyCTL
    {
        private DaiLyDTO info = new DaiLyDTO();
        private DaiLyDAO data = new DaiLyDAO();

        public DaiLyDTO HocSinh
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
