using Stimulsoft.Base.Serializing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_XuatKho
    {
        private static DAL_XuatKho instance;

        public static DAL_XuatKho Instance
        {
            get { if (instance == null) instance = new DAL_XuatKho(); return instance; }
            set { instance = value; }
        }

        private DAL_XuatKho() { }

        public DataTable LayDanhSachXuatKho()
        {
            string query = "USP_LayDanhSachXuatKho";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public bool ThemXuatKho(int maXK, DateTime ngayXuat)
        {
            string query = "USP_ThemPhieuXuatKho @MaXK , @NgayXuat";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maXK, ngayXuat });
        }

        public DataTable LayDanhSachCTXuatKho(int maXK)
        {
            string query = "USP_LayDanhSachCTXuatKho @MaXK";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { maXK });
        }

        public bool ThemCTXuatKho(int maXK, int maSach, int soLuong)
        {
            string query = "USP_ThemCTXuatKho @MaXK , @MaSach , @SoLuong";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maXK, maSach, soLuong });
        } 

        public bool XoaXuatKho(int maXK)
        {
            string query = "USP_XoaPhieuXuatKho @MaXK";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maXK });
        }

        public bool CapNhatTrangThaiXuatKho(int maXK)
        {
            string query = "USP_CapNhatTrangThaiXuatKho @MaXK";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maXK });
        }
    }
}
