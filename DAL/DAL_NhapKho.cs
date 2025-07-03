using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_NhapKho
    {
        private static DAL_NhapKho instance;

        public static DAL_NhapKho Instance
        {
            get { if (instance == null) instance = new DAL_NhapKho(); return instance; }
            set { instance = value; }
        }

        private DAL_NhapKho() { }

        public DataTable LayDanhSachNhapKho()
        {
            string query = "USP_LayDanhSachNhapKho";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { });
        }

        public bool ThemNhapKho(int maThuKho, string nhaCC, DateTime ngayNhap, int tongTien)
        {
            string query = "USP_ThemPhieuNhapKho @MaThuKho , @NhaCC , @NgayNhap , @TongTien";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maThuKho, nhaCC, ngayNhap, tongTien });
        }

        public DataTable LayDanhSachCTNhapKho(int maNK)
        {
            string query = "USP_LayDanhSachCTNhapKho @MaNK";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] {maNK });
        }
        public bool ThemCTNhapKho(int maNhapKho,  int maSach, int soLuong)
        {
            string query = "USP_ThemCTNhapKho @MaNK , @MaSach , @SoLuong";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maNhapKho, maSach, soLuong });
        }

        public bool XoaNhapKho(int maNK)
        {
            string query = "USP_XoaPhieuNhapKho @MaNK";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maNK });
        }

        public bool CapNhatTrangThaiNhapKho(int maNK)
        {
            string query = "USP_CapNhatTrangThaiNhapKho @MaNK";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maNK });
        }
    }
}
