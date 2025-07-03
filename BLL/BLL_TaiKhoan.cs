using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance; 

        public static BLL_TaiKhoan Instance { 
            get { if (instance == null) instance = new BLL_TaiKhoan(); return instance; }
            set { instance = value; }
        }

        private BLL_TaiKhoan() { }

        public DataTable DanhSach()
        {
            return DAL_TaiKhoan.Instance.DanhSach();
        }

        public bool ThemTaiKhoan( string tenDangNhap, string matKhau, string loai, string tenNguoiDung, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            matKhau = HeThong.Hash(matKhau);
            return DAL_TaiKhoan.Instance.ThemTaiKhoan(tenDangNhap, matKhau, loai, tenNguoiDung, gioiTinh, ngaySinh, diaChi, sdt);

        }

        public bool XoaTaiKhoan(int maTK)
        {
            return DAL_TaiKhoan.Instance.XoaTaiKhoan(maTK);
        }

        public bool SuaTaiKhoan(int maTK, string tenDangNhap, string matKhau, string loai, string tenNguoiDung, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            matKhau = HeThong.Hash(matKhau);
            return DAL_TaiKhoan.Instance.SuaTaiKhoan(maTK, tenDangNhap, matKhau, loai, tenNguoiDung, gioiTinh, ngaySinh, diaChi, sdt);
        }

        public bool DangNhap(string ten, string matKhau)
        {
            matKhau = HeThong.Hash(matKhau);
            return DAL_TaiKhoan.Instance.DangNhap(ten, matKhau);
        }


        public DataTable TaiTenNhanVienLen()
        {
            return DAL_TaiKhoan.Instance.TaiTenNhanVienLen();
        }

        public DataTable TaiTenThuKhoLen()
        {
            return DAL_TaiKhoan.Instance.TaiTenThuKhoLen();
        }

    }
}
