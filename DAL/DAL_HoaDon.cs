using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_HoaDon
    {
        private static DAL_HoaDon instance;

        public static DAL_HoaDon Instance
        {
            get { if (instance == null) instance = new DAL_HoaDon(); return instance; }
            set { instance = value; }
        }

        private DAL_HoaDon() { }

        public DataTable LayDanhSachHoaDon()
        {
            string query = "USP_LayDanhSachHoaDon";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHoaDonTheoMa(int maHD)
        {
            string query = "USP_LayDanhSachHoaDonTheoMa @MaHD";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] {maHD});
        }

        public bool ThemHoaDon(int maKh, int maNV, DateTime ngayLap, int tongTien)
        {
            string query = "USP_ThemHoaDon @MaKH , @MaNV , @NgayLap , @TongTien";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maKh, maNV, ngayLap, tongTien });
        }

        public bool XoaHoaDon(int maHD)
        {
            string query = "USP_XoaHoaDon @MaHD";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] {maHD});
        }

        public bool SuaHoaDon(int maHD, int maKH, int maNV)
        {
            string query = "USP_SuaHoaDon @MaHD , @MaKH , @MaNV , @NgayLap";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maHD, maKH, maNV});
        }

        public bool ThemCTHD(int maHD, int maSach, int soLuong)
        {
            string query = "USP_ThemCTHD @MaHD , @MaSach , @SoLuong";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maHD, maSach, soLuong });
        }

        public bool XoaCTHD(int maHD)
        {
            string query = "USP_XoaCTHD @MaHD";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maHD});
        }

        public DataTable LayDanhSachSachTheoCTHD(int maHD)
        {
            string query = "USP_LayDanhSachSachTheoCTHD @MaHD";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { maHD });
        }
    }
}
