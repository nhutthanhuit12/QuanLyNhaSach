using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_HoaDon
    {
        private static BLL_HoaDon instance;

        public static BLL_HoaDon Instance
        {
            get { if (instance == null) instance = new BLL_HoaDon(); return instance; }
            set { instance = value; }   
        }

        private BLL_HoaDon() { }

        public DataTable LayDanhSachHoaDon()
        {
            return DAL_HoaDon.Instance.LayDanhSachHoaDon();
        }

        public DataTable LayDanhSachHoaDonTheoMa(int maHD)
        {
            return DAL_HoaDon.Instance.LayDanhSachHoaDonTheoMa(maHD);
        }

        public bool ThemHoaDon(int maKH, int maNV, DateTime ngayLap, int tongTien) {
            return DAL_HoaDon.Instance.ThemHoaDon(maKH, maNV, ngayLap, tongTien);
        }

        public bool XoaHoaDon(int maHD)
        {
            return DAL_HoaDon.Instance.XoaHoaDon(maHD);
        }

        public bool SuaHoaDon(int maHD, int maKH, int maNV)
        {
            return DAL_HoaDon.Instance.SuaHoaDon(maHD, maKH, maNV);
        }

        public bool ThemCTHD(int maHD, int maSach, int soLuong)
        {
            return DAL_HoaDon.Instance.ThemCTHD(maHD, maSach, soLuong);
        }

        public bool XoaCTHD(int maHD)
        {
            return DAL_HoaDon.Instance.XoaCTHD(maHD);
        }

        public DataTable LayDanhSachSachTheoCTHD(int maHD)
        {
            return DAL_HoaDon.Instance.LayDanhSachSachTheoCTHD(maHD);
        }
    }

}
