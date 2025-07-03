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

namespace QuanLyNhaSach
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text.Trim();
            string matKhau = txbMatKhau.Text.Trim();
            string loaiTaiKhoan = cbLoaiTaiKhoan.SelectedItem.ToString().Trim();
            string tenNguoiDung = txbTenNguoiDung.Text.Trim();
            string gioiTinh = rdNam.Checked ? rdNam.Text : rdNu.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string diaChi = txbDiaChi.Text.Trim();
            string soDT = txbSDT.Text;



            if (tenDangNhap.Length > 0 && matKhau.Length > 0 && loaiTaiKhoan.Length > 0 && tenNguoiDung.Length > 0
                && gioiTinh.Length > 0 && ngaySinh <= DateTime.Today && diaChi.Length > 0 && soDT.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.ThemTaiKhoan(tenDangNhap, matKhau, loaiTaiKhoan, tenNguoiDung, gioiTinh, ngaySinh, diaChi, soDT))
                        btnTaiLai.PerformClick();
                }

                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
            cbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cbLoaiTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
            txbTenNguoiDung.Text = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString().Trim();
            string gioiTinh = dgvTaiKhoan.CurrentRow.Cells[5].Value.ToString().Trim();
            rdNam.Checked = gioiTinh == "Nam";
            rdNu.Checked = gioiTinh == "Nữ";
            dtpkNgaySinh.Text = dgvTaiKhoan.CurrentRow.Cells[6].Value.ToString().Trim();
            txbDiaChi.Text = dgvTaiKhoan.CurrentRow.Cells[7].Value.ToString().Trim();
            txbSDT.Text = dgvTaiKhoan.CurrentRow.Cells[8].Value.ToString().Trim();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            string ten = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa tài khoản " + ten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.XoaTaiKhoan(id))
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
            int Id = int.Parse(txbId.Text.Trim());
            string tenDangNhap = txbTenDangNhap.Text.Trim();
            string matKhau = txbMatKhau.Text.Trim();
            string loaiTaiKhoan = cbLoaiTaiKhoan.SelectedItem.ToString().Trim();
            string tenNguoiDung = txbTenNguoiDung.Text.Trim();
            string gioiTinh = rdNam.Checked ? rdNam.Text : rdNu.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            string diaChi = txbDiaChi.Text.Trim();
            string soDT = txbSDT.Text;



            if (tenDangNhap.Length > 0 && matKhau.Length > 0 && loaiTaiKhoan.Length > 0 && tenNguoiDung.Length > 0
                && gioiTinh.Length > 0 && ngaySinh <= DateTime.Now && diaChi.Length > 0 && soDT.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.SuaTaiKhoan(Id, tenDangNhap, matKhau, loaiTaiKhoan, tenNguoiDung , gioiTinh, ngaySinh, diaChi, soDT))
                        btnTaiLai.PerformClick();
                }

                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
