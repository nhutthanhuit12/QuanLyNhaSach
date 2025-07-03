using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DAL;
using QuanLyNhaSach.Report;
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
    public partial class fNhapKho : Form
    {
        public fNhapKho()
        {
            InitializeComponent();
            loadcbTenSach();
            loadtxbMaSach();
            loadcbTenThuKho();
            loadtxbMaThuKho();
            loaddgvNhapKho();

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

        private void loadcbTenThuKho()
        {
            DataTable dt = BLL_TaiKhoan.Instance.TaiTenThuKhoLen();
            cbTenThuKho.DataSource = dt;
            cbTenThuKho.DisplayMember = "TenNguoiDung";
            cbTenThuKho.ValueMember = "MaTK";
        }

        private void loadtxbMaThuKho()
        {
            if (cbTenThuKho.SelectedIndex != -1)
            {
                txbMaThuKho.Text = cbTenThuKho.SelectedValue.ToString();
            }
        }

        private void cbTenThuKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxbMaThuKho();
        }


        private void loaddgvCTNhapKho()
        {
            int maNK = int.Parse(txbMaNhapKho.Text.Trim());
            dgvCTNhapKho.DataSource = BLL_NhapKho.Instance.LayDanhSachCTNhapKho(maNK);
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


            if (soLuong == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tim don gia
            int donGia = BLL_Sach.Instance.LayGiaGocSach(maSach);
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

        private void loaddgvNhapKho()
        {
            if (BLL_NhapKho.Instance.LayDanhSachNhapKho() != null)
                dgvNhapKho.DataSource = BLL_NhapKho.Instance.LayDanhSachNhapKho();
        }



        private void btnThemNK_Click(object sender, EventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm sách vào nhập kho. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int maThuKho = int.Parse(txbMaThuKho.Text.Trim());
            string nhaCC = txbNhaCungCap.Text.Trim();
            DateTime ngayNhap = dtpkNgayNhap.Value;
            int tongTien = int.Parse(txbTongTien.Text.Trim());

            if (maThuKho > 0 && ngayNhap <= DateTime.Now && tongTien > 0)
            {
                if (nhaCC.Length == 0)
                {
                    MessageBox.Show("Nhà cung cấp đang trống. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (BLL_NhapKho.Instance.ThemNhapKho(maThuKho, nhaCC, ngayNhap, tongTien))
                {
                    loaddgvNhapKho();
                    int maNhapKho = int.Parse(dgvNhapKho.Rows[dgvNhapKho.Rows.Count - 1].Cells[0].Value.ToString());
                    foreach (DataGridViewRow row in dgvSach.Rows)
                    {
                        int maSach = int.Parse(row.Cells[0].Value.ToString().Trim());
                        int soLuong = int.Parse(row.Cells[2].Value.ToString().Trim());
                        if (BLL_NhapKho.Instance.ThemCTNhapKho(maNhapKho, maSach, soLuong))
                        {
                            continue;
                        }
                    }
                }
            }

            dgvSach.Rows.Clear();
        }

        private void dgvNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNhapKho.Text = dgvNhapKho.CurrentRow.Cells[0].Value.ToString().Trim();
            cbTenThuKho.Text = dgvNhapKho.CurrentRow.Cells[1].Value.ToString().Trim();
            txbNhaCungCap.Text = dgvNhapKho.CurrentRow.Cells[2].Value.ToString().Trim();
            txbTongTien.Text = dgvNhapKho.CurrentRow.Cells[3].Value.ToString().Trim();

            loaddgvCTNhapKho();
        }

        private void btnXoaNK_Click(object sender, EventArgs e)
        {
            if (txbMaNhapKho.Text.Length == 0)
                return;

            int maNK = int.Parse(txbMaNhapKho.Text.Trim());

            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập kho này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_NhapKho.Instance.XoaNhapKho(maNK))
                    {
                        loaddgvNhapKho();
                        loaddgvCTNhapKho();

                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi xảy ra. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSuaNK_Click(object sender, EventArgs e)
        {

        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            if (txbMaNhapKho.Text.Length == 0)
                return;
            int maNK = int.Parse(txbMaNhapKho.Text.Trim());
            if (BLL_NhapKho.Instance.CapNhatTrangThaiNhapKho(maNK))
            {
                loaddgvNhapKho();
                MessageBox.Show("Phê duyệt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fNhapKho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
