using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private DAL_TaiKhoan() { }

        public bool DangNhap(string ten, string matKhau)
        {
            string query = "select * from TAIKHOAN where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            DataTable result = DAL_KetNoi.Instance.ExecuteQuery(query, new object[] {ten, matKhau});
            if (result.Rows.Count > 0)
            {
                HeThong.LOAITAIKHOAN = result.Rows[0]["LoaiTaiKhoan"].ToString().Trim();
                return true;
            }
            else
                return false;
        }

        public bool ThemTaiKhoan(string tenDangNhap, string matKhau, string loai, string tenNguoiDung, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            string query = "USP_ThemTaiKhoan @TenDangNhap , @MatKhau , @TenNguoiDung , @LoaiNguoiDung , @GioiTinh , @NgaySinh , @DiaChi , @SoDT ";

            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] {tenDangNhap, matKhau, loai, tenNguoiDung, gioiTinh, ngaySinh, diaChi, sdt});

        }

        public bool XoaTaiKhoan(int maTK)
        {
            string query = "USP_XoaTaiKhoan @MaTK";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] {maTK});
        }

        public bool SuaTaiKhoan(int maTK, string tenDangNhap, string matKhau, string tenNguoiDung , string loai, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            string query = "USP_SuaTaiKhoan @MaTK , @TenDangNhap , @MatKhau , @TenNguoiDung , @LoaiNguoiDung , @GioiTinh , @NgaySinh , @DiaChi , @SoDT";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maTK, tenDangNhap, matKhau, tenNguoiDung, loai , gioiTinh, ngaySinh, diaChi, sdt });
        }

        public DataTable DanhSach()
        {
            string query = "USP_DanhSachTaiKhoan";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public DataTable TaiTenNhanVienLen()
        {
            string query = "USP_TaiTenNhanVienLen";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public DataTable TaiTenThuKhoLen()
        {
            string query = "USP_TaiTenThuKhoLen";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }
    }
}
