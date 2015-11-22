using System;
using System.Collections;
using System.Data.OleDb;

namespace QuanLyDaiLy
{
    class LoaiDaiLyCTL
    {
        private LoaiDaiLyDTO info = new LoaiDaiLyDTO();
        private LoaiDaiLyDAO data = new LoaiDaiLyDAO();

        public LoaiDaiLyDTO LoaiDaiLy
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
            data.delete(info.MaLoaiDaiLy);
        }

        public void update()
        {
            data.update(info);
        }

        public ArrayList getDsLoaiDaiLy()
        {
            return data.getDsLoaiDaiLy();
        }
    }
}
