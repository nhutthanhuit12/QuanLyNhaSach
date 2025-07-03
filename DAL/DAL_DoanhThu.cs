using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaSach.DAL
{
    public class DAL_DoanhThu
    {
        private static DAL_DoanhThu instance;

        public static DAL_DoanhThu Instance
        {
            get { if (instance == null) instance = new DAL_DoanhThu(); return instance; }
            set { instance = value; }
        }

        private DAL_DoanhThu() { }

        public DataTable ThongKeDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "USP_ThongKeDoanhThu @NgayBatDau , @NgayKetThuc";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { ngayBatDau, ngayKetThuc });
        }
    }
}
