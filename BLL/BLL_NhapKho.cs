using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_NhapKho
    {
        private static BLL_NhapKho instance;

        public static BLL_NhapKho Instance {
            get { if (instance == null) instance = new BLL_NhapKho(); return instance; }
            set { instance = value; }
        }

        private BLL_NhapKho() { }

        public DataTable LayDanhSachNhapKho()
        {
            return DAL_NhapKho.Instance.LayDanhSachNhapKho();
        }

        public bool ThemNhapKho(int maThuKho, string nhaCC, DateTime ngayNhap, int tongTien)
        {
            return DAL_NhapKho.Instance.ThemNhapKho(maThuKho, nhaCC, ngayNhap, tongTien);
        }

        public DataTable LayDanhSachCTNhapKho(int maNK)
        {
            return DAL_NhapKho.Instance.LayDanhSachCTNhapKho(maNK);
        }

        public bool ThemCTNhapKho(int maThuKho, int maSach, int soLuong)
        {
            return DAL_NhapKho.Instance.ThemCTNhapKho(maThuKho , maSach , soLuong);
        }

        public bool XoaNhapKho(int maNK)
        {
            return DAL_NhapKho.Instance.XoaNhapKho(maNK);
        }

        public bool CapNhatTrangThaiNhapKho(int maNK)
        {
            return DAL_NhapKho.Instance.CapNhatTrangThaiNhapKho(maNK);
        }
    }
}
