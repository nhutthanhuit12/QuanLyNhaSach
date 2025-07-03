using QuanLyNhaSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace QuanLyNhaSach.GUI
{
    public partial class fXemDoanhThu : Form
    {
        public fXemDoanhThu()
        {
            InitializeComponent();
        }

        private void loaddgvDoanhThu()
        {
            DateTime ngayBatDau = dtpkNgayBatDau.Value;
            DateTime ngayKetThuc = dtpkNgayKetThuc.Value;
            dgvHoaDon.DataSource = BLL_DoanhThu.Instance.ThongKeDoanhThu(ngayBatDau, ngayKetThuc);
        }

        private void loadchartDoanhThu()
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Series.Add("Doanh Thu");
            chartDoanhThu.Series["Doanh Thu"].ChartType = SeriesChartType.Column;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                decimal doanhThu = Convert.ToDecimal(row.Cells["TongTien"].Value);

                chartDoanhThu.Series["Doanh Thu"].Points.AddXY(ngay.ToShortDateString(), doanhThu);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loaddgvDoanhThu();
            loadchartDoanhThu();
        }
    }
}
