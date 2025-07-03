using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAL
{
    public class DAL_Sach
    {
        private static DAL_Sach instance;

        public static DAL_Sach Instance
        {
            get { if(instance == null) instance = new DAL_Sach(); return instance; }
            set { instance = value; }
        }

        private DAL_Sach() { }
        

        public DataTable DanhSach()
        {
            string query = "USP_DanhSachSach";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public bool ThemSach(string tenSach, string theLoai, string tacGia, string nxb, DateTime ngayxb, int giaGoc, int giaBan)
        {
            string query = "USP_ThemSach @TenSach , @TheLoai , @TacGia , @NXB , @NgayXB , @GiaGoc , @GiaBan";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] {tenSach, theLoai, tacGia, nxb, ngayxb, giaGoc, giaBan });
        }

        public bool XoaSach(int maSach)
        {
            string query = "USP_XoaSach @MaSach";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maSach });
        }

        public bool SuaSach(int maSach, string tenSach, string theLoai, string tacGia, string nxb, DateTime ngayxb, int giaGoc, int giaBan)
        {
            string query = "USP_SuaSach @MaSach , @TenSach , @TheLoai , @TacGia , @NXB , @NgayXB , @GiaGoc , @GiaBan";
            return DAL_KetNoi.Instance.ExecuteNonQuery(query, new object[] { maSach, tenSach, theLoai, tacGia, nxb, ngayxb, giaGoc, giaBan});
        }

        public DataTable TimSach(string tenSach)
        {
            string query = "USP_TimSachTheoTen @TenSach";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { tenSach });
        }

        public DataTable TaiTenSachLen()
        {
            string query = "USP_TaiTenSachLen";
            return DAL_KetNoi.Instance.ExecuteQuery(query);
        }

        public DataTable LayDonGiaSach(int maSach)
        {
            string query = "USP_LayDonGiaSach @MaSach";
            return DAL_KetNoi.Instance.ExecuteQuery(query, new object[] { maSach });
        }

        public int LayGiaGocSach(int maSach)
        {
            string query = "USP_LayGiaGocSach @MaSach";
            object re =  DAL_KetNoi.Instance.ExecuteScalar(query, new object[] { maSach });
            return int.Parse(re.ToString());
        }

        public int LayTonKhoSach(int maSach)
        {
            string query = "USP_LayTonKhoSach @MaSach";
            object re = DAL_KetNoi.Instance.ExecuteScalar(query, new object[] {maSach});
            return int.Parse(re.ToString());
        }

        public int LayTaiQuaySach(int maSach)
        {
            string query = "USP_LayTaiQuaySach @MaSach";
            object re = DAL_KetNoi.Instance.ExecuteScalar(query, new object[] { maSach });
            return int.Parse(re.ToString());
        }
    }
}
