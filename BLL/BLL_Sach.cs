using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_Sach
    {
        private static BLL_Sach instance;

        public static BLL_Sach Instance
        {
            get { if (instance == null) instance = new BLL_Sach(); return instance; }
            set { instance = value; }
        }

        private BLL_Sach() { }

        public DataTable DanhSach()
        {
            return DAL_Sach.Instance.DanhSach();
        }

        public bool ThemSach(string tenSach, string theLoai, string tacGia, string nxb, DateTime ngayxb, int giaGoc, int giaBan)
        {
            return DAL_Sach.Instance.ThemSach(tenSach, theLoai, tacGia, nxb, ngayxb, giaGoc, giaBan);
        }

        public bool XoaSach(int maSach)
        {
            return DAL_Sach.Instance.XoaSach(maSach);
        } 

        public bool SuaSach(int maSach, string tenSach, string theLoai, string tacGia, string nxb, DateTime ngayxb, int giaGoc, int giaBan)
        {
            return DAL_Sach.Instance.SuaSach(maSach, tenSach, theLoai, tacGia, nxb, ngayxb, giaGoc , giaBan);
        }

        public DataTable TimSach(string tenSach)
        {
            return DAL_Sach.Instance.TimSach(tenSach);
        }

        public DataTable TaiTenSachLen()
        {
            return DAL_Sach.Instance.TaiTenSachLen();
        }

        public DataTable LayDonGiaSach(int maSach)
        {
            return DAL_Sach.Instance.LayDonGiaSach(maSach);
        }

        public int LayGiaGocSach(int maSach)
        {
            return DAL_Sach.Instance.LayGiaGocSach(maSach);
        }

        public int LayTonKhoSach(int maSach)
        {
            return DAL_Sach.Instance.LayTonKhoSach(maSach);
        }

        public int LayTaiQuaySach(int maSach)
        {
            return DAL_Sach.Instance.LayTaiQuaySach(maSach);
        }

    }
}
