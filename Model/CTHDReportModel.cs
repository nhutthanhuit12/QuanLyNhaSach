using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class CTHDReportModel
    {
        private static CTHDReportModel instance;    

        public static CTHDReportModel Instance
        {
            get { if (instance == null) instance = new CTHDReportModel(); return instance; }
            set { instance = value; }   
        }

        private CTHDReportModel() { }

        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
    }
}
