using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLL_XuatKho
    {
        private static BLL_XuatKho instance;

        public static BLL_XuatKho Instance
        {
            get { if (instance == null) instance = new BLL_XuatKho(); return instance; }
            set {  instance = value; }
        }

        private BLL_XuatKho() { }

        public DataTable LayDanhSachXuatKho()
        {
            return DAL_XuatKho.Instance.LayDanhSachXuatKho();
        }

        public bool ThemXuatKho(int maXK, DateTime ngayXuat)
        {
            return DAL_XuatKho.Instance.ThemXuatKho(maXK, ngayXuat);
        } 

        public DataTable LayDanhSachCTXuatKho(int maXK)
        {
            return DAL_XuatKho.Instance.LayDanhSachCTXuatKho(maXK);
        }
        public bool ThemCTXuatKho(int maXK, int maSach, int soLuong)
        {
            return DAL_XuatKho.Instance.ThemCTXuatKho(maXK, maSach, soLuong);
        }

        public bool XoaXuatKho(int maXK)
        {
            return DAL_XuatKho.Instance.XoaXuatKho(maXK);
        }

        public bool CapNhatTrangThaiXuatKho(int maXK)
        {
            return DAL_XuatKho.Instance.CapNhatTrangThaiXuatKho(maXK);
        }
    }
}
