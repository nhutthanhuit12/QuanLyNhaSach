using QuanLyNhaSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyNhaSach.GUI
{
    public partial class fQuanLyKhachHang : Form
    {
        public fQuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void fQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString().Trim();
            string gioiTinh = dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
            rdNam.Checked = gioiTinh == "Nam";
            rdNu.Checked = gioiTinh == "Nữ";
            txbDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString().Trim();
            txbSDT.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString().Trim();


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txbTenKhachHang.Text.Trim();
            string gioiTinh = rdNam.Checked ? rdNam.Text : rdNu.Text;
            string diaChi = txbDiaChi.Text.Trim();
            string soDT = txbSDT.Text.Trim();


            if (tenKhachHang.Length > 0 && gioiTinh.Length > 0 && diaChi.Length > 0 && soDT.Length > 0)
            {
                try
                {
                    if (BLL_KhachHang.Instance.ThemKhachHang(tenKhachHang, gioiTinh, diaChi, soDT))
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

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BLL_KhachHang.Instance.DanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKhachHang.CurrentRow.Cells[1].Value.ToString());
            string ten = dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa khách hàng " + ten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_KhachHang.Instance.XoaKhachHang(id))
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
            int Id = int.Parse(txbId.Text.Trim());
            string tenKhachHang = txbTenKhachHang.Text.Trim();
            string gioiTinh = rdNam.Checked ? rdNam.Text : rdNu.Text;
            string diaChi = txbDiaChi.Text.Trim();
            string soDT = txbSDT.Text.Trim();

            if (tenKhachHang.Length > 0 && gioiTinh.Length > 0 && diaChi.Length > 0 && soDT.Length > 0)
            {
                try
                {
                    if (BLL_KhachHang.Instance.SuaKhachHang(Id, tenKhachHang, gioiTinh,  diaChi, soDT))
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
    }
}
