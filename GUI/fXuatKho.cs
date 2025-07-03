using Microsoft.CodeAnalysis.CSharp.Syntax;
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
    public partial class fXuatKho : Form
    {
        private static int tonKhoToiThieu = 0;
        public fXuatKho()
        {
            InitializeComponent();
            loadcbTenSach();
            loadcbTenNhanVien();
            loadtxbMaSach();
            loadtxbMaNhanVien();
            loaddgvXuatKho();

            if (HeThong.LOAITAIKHOAN == "Quản lý")
                btnPheDuyet.Visible = true;
            else
                btnPheDuyet.Visible = false;
        }


        private void loadcbTenSach()
        {
            DataTable dt = BLL_Sach.Instance.DanhSach();
            cbTenSach.DataSource = dt;
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
        }

        private void loadtxbMaSach()
        {
            if (cbTenSach.SelectedIndex != -1)
            {
                txbMaSach.Text = cbTenSach.SelectedValue.ToString();
            }
        }


        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaSach();
        }

        private void loadcbTenNhanVien()
        {
            DataTable dt = BLL_TaiKhoan.Instance.TaiTenNhanVienLen();
            cbTenNhanVien.DataSource = dt;
            cbTenNhanVien.DisplayMember = "TenNguoiDung";
            cbTenNhanVien.ValueMember = "MaTK";
        }

        private void loadtxbMaNhanVien()
        {
            if (cbTenNhanVien.SelectedIndex != -1)
            {
                txbMaNhanVien.Text = cbTenNhanVien.SelectedValue.ToString();
            }
        }


        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaNhanVien();
        }

        private void loaddgvCTXuatKho()
        {
            int maXK = int.Parse(txbMaXuatKho.Text.Trim());
            dgvCTXuatKho.DataSource = BLL_XuatKho.Instance.LayDanhSachCTXuatKho(maXK);
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
                    return;
                }
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {

            int maSach = int.Parse(txbMaSach.Text.Trim());
            string tenSach = cbTenSach.Text.Trim();
            int soLuong = int.Parse(nmrSoLuong.Text.Trim());


            if (soLuong == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tonKhoThucTe = BLL_Sach.Instance.LayTonKhoSach(maSach);

            if(tonKhoThucTe < tonKhoToiThieu + soLuong)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (checkdgvSach(maSach))
                dgvSach.Rows.Add(maSach, tenSach, soLuong);
            else
                updatedgvSach(maSach, soLuong);


        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
                return;

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

        }

        private void loaddgvXuatKho()
        {
            if (BLL_XuatKho.Instance.LayDanhSachXuatKho() != null)
                dgvXuatKho.DataSource = BLL_XuatKho.Instance.LayDanhSachXuatKho();
        }

        private void btnThemXK_Click(object sender, EventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm sách vào xuất kho. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int maNV = int.Parse(txbMaNhanVien.Text.Trim());
            DateTime ngayXuat = dtpkNgayXuat.Value;

            if (maNV > 0 && ngayXuat <= DateTime.Now)
            {
                if (BLL_XuatKho.Instance.ThemXuatKho(maNV, ngayXuat))
                {
                    loaddgvXuatKho();
                    int maXK = int.Parse(dgvXuatKho.Rows[dgvXuatKho.Rows.Count - 1].Cells[0].Value.ToString());
                    foreach (DataGridViewRow row in dgvSach.Rows)
                    {
                        int maSach = int.Parse(row.Cells[0].Value.ToString().Trim());
                        int soLuong = int.Parse(row.Cells[2].Value.ToString().Trim());
                        if (BLL_XuatKho.Instance.ThemCTXuatKho(maXK, maSach, soLuong))
                        {
                            continue;
                        }
                    }
                }
            }

            dgvSach.Rows.Clear();
        }

        private void dgvXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaXuatKho.Text = dgvXuatKho.CurrentRow.Cells[0].Value.ToString().Trim();
            cbTenNhanVien.Text = dgvXuatKho.CurrentRow.Cells[1].Value.ToString().Trim();

            loaddgvCTXuatKho();
        }

        private void btnXoaXK_Click(object sender, EventArgs e)
        {
            if (txbMaXuatKho.Text.Length == 0)
                return;
            int maXK = int.Parse(txbMaXuatKho.Text.Trim());
            if (MessageBox.Show("Bạn có muốn xóa phiếu xuất kho này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_XuatKho.Instance.XoaXuatKho(maXK))
                    {
                        loaddgvXuatKho();
                        loaddgvCTXuatKho();

                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi xảy ra. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            if (txbMaXuatKho.Text.Length == 0)
                return;
            int maXK = int.Parse(txbMaXuatKho.Text.Trim());
            if (BLL_XuatKho.Instance.CapNhatTrangThaiXuatKho(maXK))
            {
                loaddgvXuatKho();
                MessageBox.Show("Phê duyệt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            fChinhSuaTonKho f = new fChinhSuaTonKho();
            this.Hide();
            if (f.ShowDialog() == DialogResult.OK) {
                tonKhoToiThieu = f.layTonKhoToiThieu();
            }
            this.Show();
        }
    }
}
