using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_DoanhThu
    {
        private static BLL_DoanhThu instance;

        public static BLL_DoanhThu Instance
        {
            get { if (instance == null) instance = new BLL_DoanhThu(); return instance; }
            set { instance = value; }
        }

        private BLL_DoanhThu() { }

        public DataTable ThongKeDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DAL_DoanhThu.Instance.ThongKeDoanhThu(ngayBatDau, ngayKetThuc);
        }
    }
}
