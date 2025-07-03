using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaSach.BLL;

public class BLL_KhachHang
{
    private static BLL_KhachHang instance;

    public static BLL_KhachHang Instance
    {
        get { if (instance == null) instance = new BLL_KhachHang(); return instance; }
        set { instance = value; }
    }

    private BLL_KhachHang() { }

    public DataTable DanhSach()
    {
        return DAL_KhachHang.Instance.DanhSach();
    }

    public bool ThemKhachHang(string tenKH, string gioiTinh, string diaChi, string soDT)
    {
        return DAL_KhachHang.Instance.ThemKhachHang(tenKH, gioiTinh, diaChi, soDT);
    }

    public bool XoaKhachHang(int maKH)
    {
        return DAL_KhachHang.Instance.XoaKhachHang(maKH);
    }

    public bool SuaKhachHang(int maKH, string tenKhachHang, string gioiTinh, string diaChi, string soDT)
    {
        return DAL_KhachHang.Instance.SuaKhachHang(maKH, tenKhachHang, gioiTinh, diaChi, soDT);
    }

    public DataTable TaiTenKhachHangLen()
    {
        return DAL_KhachHang.Instance.TaiTenKhachHangLen();
    }
}
