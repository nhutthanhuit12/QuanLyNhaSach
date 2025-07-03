using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return instance; }
            set { instance = value; }
        }

        private DAL_KhachHang() { }


        public DataTable DanhSach()
        {
            string query = "USP_DanhSachKhachHang";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public bool ThemKhachHang(string tenKH, string gioiTinh, string diaChi, string soDT)
        {
            string query = "USP_ThemKhachHang @TenKH , @GioiTinh , @DiaChi , @SoDT";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { tenKH, gioiTinh, diaChi, soDT });
        }

        public bool XoaKhachHang(int maKH)
        {
            string query = "USP_XoaKhachHang @MaKH";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maKH });
        }

        public bool SuaKhachHang(int maKH ,string tenKH, string gioiTinh, string diaChi, string soDT)
        {
            string query = "USP_SuaKhachHang @MaKH , @TenKH , @GioiTinh , @DiaChi , @SoDT";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maKH, tenKH, gioiTinh, diaChi, soDT });
        }

        public DataTable TaiTenKhachHangLen()
        {
            string query = "USP_TaiTenKhachHangLen";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }
    }
}
