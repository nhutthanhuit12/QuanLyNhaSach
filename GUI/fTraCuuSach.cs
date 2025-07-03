using Microsoft.Identity.Client;
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

namespace QuanLyNhaSach.GUI
{
    public partial class fTraCuuSach : Form
    {
        public fTraCuuSach()
        {
            InitializeComponent();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvTraCuuSach.DataSource = BLL_Sach.Instance.DanhSach();
        }
        private void fTraCuuSach_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }
        private void dgvTraCuuSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvTraCuuSach.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenSach.Text = dgvTraCuuSach.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTheLoai.Text = dgvTraCuuSach.CurrentRow.Cells[2].Value.ToString().Trim();
            txbTacGia.Text = dgvTraCuuSach.CurrentRow.Cells[3].Value.ToString().Trim();
            txbNXB.Text = dgvTraCuuSach.CurrentRow.Cells[4].Value.ToString().Trim();
            dtpkNgayXB.Text = dgvTraCuuSach.CurrentRow.Cells[5].Value.ToString().Trim();
            txbGiaGoc.Text = dgvTraCuuSach.CurrentRow.Cells[6].Value.ToString().Trim();
            txbGiaBan.Text = dgvTraCuuSach.CurrentRow.Cells[7].Value.ToString().Trim();
            txbTaiQuay.Text = dgvTraCuuSach.CurrentRow.Cells[8].Value.ToString().Trim();
            txbTonKho.Text = dgvTraCuuSach.CurrentRow.Cells[9].Value.ToString().Trim();
            txbDaBan.Text = dgvTraCuuSach.CurrentRow.Cells[10].Value.ToString().Trim();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbGiaGoc.Text.Length == 0)
                return;
            if (txbGiaBan.Text.Length == 0)
                return;

            string tenSach = txbTenSach.Text.Trim();
            string theLoai = txbTheLoai.Text.Trim();
            string tacGia = txbTacGia.Text.Trim();
            string nxb = txbNXB.Text.Trim();
            DateTime ngayXB = dtpkNgayXB.Value;
            int giaGoc = int.Parse(txbGiaGoc.Text.Trim());
            int giaBan = int.Parse(txbGiaBan.Text.Trim());

            if(ngayXB > DateTime.Now)
            {
                MessageBox.Show("Ngày xuất bản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tenSach.Length > 0 && theLoai.Length > 0 && tacGia.Length > 0 && nxb.Length > 0)
            {
                    if (BLL_Sach.Instance.ThemSach(tenSach, theLoai, tacGia, nxb, ngayXB, giaGoc, giaBan))
                        btnTaiLai.PerformClick();
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvTraCuuSach.CurrentRow.Cells[0].Value.ToString().Trim());
            string ten = dgvTraCuuSach.CurrentRow.Cells[1].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa sách " + ten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Sach.Instance.XoaSach(id))
                        btnTaiLai.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txbId.Text.Length == 0)
                return;
            int maSach = int.Parse(txbId.Text.Trim());
            string tenSach = txbTenSach.Text.Trim();
            string theLoai = txbTheLoai.Text.Trim();
            string tacGia = txbTacGia.Text.Trim();
            string nxb = txbNXB.Text.Trim();
            DateTime ngayXB = dtpkNgayXB.Value;
            int giaGoc = int.Parse(txbGiaGoc.Text.Trim());
            int giaBan = int.Parse(txbGiaBan.Text.Trim());

            if (tenSach.Length > 0 && theLoai.Length > 0 && tacGia.Length > 0 && nxb.Length > 0 && ngayXB <= DateTime.Now
                && giaGoc > 0 && giaBan > 0)
            {
                try
                {
                    if (BLL_Sach.Instance.SuaSach(maSach, tenSach, theLoai, tacGia, nxb, ngayXB, giaGoc, giaBan))
                        btnTaiLai.PerformClick();
                }

                catch
                {
                    MessageBox.Show("Lỗi! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenSach = txbTenSach.Text.Trim();
            dgvTraCuuSach.DataSource = BLL_Sach.Instance.TimSach(tenSach);
        }
    }
}
