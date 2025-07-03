using QuanLyNhaSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;


namespace QuanLyNhaSach.GUI
{
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
            loadcbTenSach();
            loadtxbMaSach();
            loadcbTenNhanVien();
            loadtxbMaNhanVien();
            loadcbTenKhachHang();
            loadtxbMaKhachHang();
            loaddgvHoaDon();

        }

        private void loadcbTenSach()
        {
            DataTable dt = BLL_Sach.Instance.TaiTenSachLen();
            cbTenSach.DataSource = dt;
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";

        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaSach();
        }
        private void loadtxbMaSach()
        {
            if (cbTenSach.SelectedIndex != -1)
            {
                txbMaSach.Text = cbTenSach.SelectedValue.ToString();
            }
        }

        private void loadcbTenNhanVien()
        {
            DataTable dt = BLL_TaiKhoan.Instance.TaiTenNhanVienLen();
            cbTenNhanVien.DataSource = dt;
            cbTenNhanVien.DisplayMember = "TenNguoiDung";
            cbTenNhanVien.ValueMember = "MaTK";
        }

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaNhanVien();
        }

        private void loadtxbMaNhanVien()
        {
            if (cbTenNhanVien.SelectedIndex != -1)
                txbMaNhanVien.Text = cbTenNhanVien.SelectedValue.ToString();
        }

        private void loadcbTenKhachHang()
        {
            DataTable dt = BLL_KhachHang.Instance.TaiTenKhachHangLen();
            cbTenKhachHang.DataSource = dt;
            cbTenKhachHang.DisplayMember = "TenKH";
            cbTenKhachHang.ValueMember = "MaKH";
        }

        private void cbTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaKhachHang();
        }

        private void loadtxbMaKhachHang()
        {
            if (cbTenKhachHang.SelectedIndex != null)
                txbMaKhachHang.Text = cbTenKhachHang.SelectedValue.ToString();
        }

        private bool checkdgvSach(int maSach)
        {
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == maSach)
                    return false;
            }
            return true;
        }

        private void updatedgvSach(int maSach, int soLuong)
        {
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == maSach)
                {
                    int soLuongMoi = int.Parse(row.Cells["SoLuong"].Value.ToString()) + soLuong;
                    row.Cells["SoLuong"].Value = soLuongMoi;
                    int thanhTienMoi = int.Parse(row.Cells["ThanhTien"].Value.ToString())
                        + soLuong * int.Parse(row.Cells["DonGia"].Value.ToString());
                    row.Cells["ThanhTien"].Value = thanhTienMoi;

                    return;
                }
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int maSach = int.Parse(txbMaSach.Text.Trim());
            string tenSach = cbTenSach.Text.Trim();
            int soLuong = int.Parse(nmrSoLuong.Text.Trim());

            int soSachTaiQuay = BLL_Sach.Instance.LayTaiQuaySach(maSach);
            
            if (soLuong > soSachTaiQuay)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tim don gia
            DataTable dt = BLL_Sach.Instance.LayDonGiaSach(maSach);
            int donGia = int.Parse(dt.Rows[0]["GiaBan"].ToString().Trim());
            int thanhTien = donGia * soLuong;

            if (checkdgvSach(maSach))
                dgvSach.Rows.Add(maSach, tenSach, soLuong, donGia, thanhTien);
            else
                updatedgvSach(maSach, soLuong);

            int tien = tinhTongTien();
            txbTongTien.Text = tien.ToString();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach.Rows.Count == 0) return;

            txbMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString().Trim();
            cbTenSach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString().Trim();
            nmrSoLuong.Text = dgvSach.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
                return;
            foreach (DataGridViewRow row in dgvSach.SelectedRows)
                dgvSach.Rows.Remove(row);

            int tien = tinhTongTien();
            txbTongTien.Text = tien.ToString();
        }

        private int tinhTongTien()
        {
            int tien = 0;
            if (dgvSach.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSach.Rows)
                {
                    tien += int.Parse(row.Cells["ThanhTien"].Value.ToString().Trim());
                }
            }
            return tien;
        }

        private void loaddgvHoaDon()
        {
            if (BLL_HoaDon.Instance.LayDanhSachHoaDon() != null)
                dgvHoaDon.DataSource = BLL_HoaDon.Instance.LayDanhSachHoaDon();
        }
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
                return;

            int maHoaDon = int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString().Trim());
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_HoaDon.Instance.XoaHoaDon(maHoaDon))
                    {
                        loaddgvHoaDon();
                        loaddgvCTHD();

                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi xảy ra. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMaHoaDon.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn. Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int maHD = int.Parse(txbMaHoaDon.Text.Trim());
            int maKH = int.Parse(txbMaKhachHang.Text.Trim());
            int maNV = int.Parse(txbMaNhanVien.Text.Trim());

            if (maHD > 0 && maKH > 0 && maNV > 0)
            {
                try
                {
                    if (BLL_HoaDon.Instance.SuaHoaDon(maHD, maKH, maNV))
                    {
                        loaddgvHoaDon();
                        loaddgvCTHD();
                    }
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu hoặc sai. Vui lòng sửa lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvSach.Rows.Clear();

        }


        private void loaddgvCTHD()
        {
            int maHD = int.Parse(txbMaHoaDon.Text.Trim());
            DataTable dt = BLL_HoaDon.Instance.LayDanhSachSachTheoCTHD(maHD);
            dgvCTHD.DataSource = dt;

        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaHoaDon.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhachHang.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString().Trim();
            cbTenKhachHang.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString().Trim();
            txbMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString().Trim();
            cbTenNhanVien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString().Trim();
            dtpkNgayLap.Text = dgvHoaDon.CurrentRow.Cells[5].Value.ToString().Trim();
            txbTongTien.Text = dgvHoaDon.CurrentRow.Cells[6].Value.ToString().Trim();

            loaddgvCTHD();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMaHoaDon.Text)) return;
            int maHD = int.Parse(txbMaHoaDon.Text.Trim());


            StiReport report = new StiReport();
            report.Load("C:\\Users\\LENOVO\\Documents\\Projects\\C#\\QuanLyNhaSach\\Report\\HoaDon.mrt");

            DataSet data = new DataSet();

            DataTable dt1 = BLL_HoaDon.Instance.LayDanhSachHoaDonTheoMa(maHD);
            DataTable dt2 = BLL_HoaDon.Instance.LayDanhSachSachTheoCTHD(maHD);

            dt1.TableName = "HoaDon";
            dt2.TableName = "ChiTietHoaDon";

            data.Tables.Add(dt1);
            data.Tables.Add(dt2);

            report.RegData("data", data);
            report.Dictionary.Synchronize();
            //report.Design();
            report.Render();
            report.Show();

        }

        private void btnThemHoaDon_Click_(object sender, EventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm sách vào hóa đơn. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maKhachHang = int.Parse(txbMaKhachHang.Text.Trim());
            string tenKhachHang = cbTenKhachHang.Text.ToString().Trim();
            int maNhanVien = int.Parse(txbMaNhanVien.Text.ToString().Trim());
            string tenNhanVien = cbTenNhanVien.Text.ToString().Trim(); ;
            DateTime ngayLap = dtpkNgayLap.Value;
            int tongTien = int.Parse(txbTongTien.Text.ToString().Trim());

            if (maKhachHang > 0 && tenKhachHang.Length > 0 && maNhanVien > 0 && tenNhanVien.Length > 0 && tongTien > 0)
                if (BLL_HoaDon.Instance.ThemHoaDon(maKhachHang, maNhanVien, ngayLap, tongTien))
                {
                    loaddgvHoaDon();
                    int maHD = int.Parse(dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 1].Cells[0].Value.ToString());
                    foreach (DataGridViewRow row in dgvSach.Rows)
                    {
                        int maSach = int.Parse(row.Cells[0].Value.ToString().Trim());
                        int soLuong = int.Parse(row.Cells[2].Value.ToString().Trim());
                        if (BLL_HoaDon.Instance.ThemCTHD(maHD, maSach, soLuong))    
                        {
                            continue;
                        }
                    }
                }

            dgvSach.Rows.Clear();
        }
    }


}