using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class HoaDonReportModel
    {
        private static HoaDonReportModel instance;

        public static HoaDonReportModel Instance
        {
            get { if(instance == null) instance = new HoaDonReportModel(); return instance; }   
            set { instance = value; }
        }

        private HoaDonReportModel() { }

        public int MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
    }
}
