using QuanLyNhaSach.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class fQuanLyNhaSach : Form
    {
        public fQuanLyNhaSach()
        {
            InitializeComponent();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fQuanLyNhaSach_Load(object sender, EventArgs e)
        {
            if(HeThong.LOAITAIKHOAN == "Nhân viên")
            {
                btnQuanLyTaiKhoan.Visible = false;
                lậpPhiếuNhậpKhoToolStripMenuItem1.Visible = false;
                btnXemDoanhThu.Visible = false;
            }
            else if(HeThong.LOAITAIKHOAN == "Thủ kho")
            {
                btnQuanLyTaiKhoan.Visible = false;
                lậpPhiếuXuấtKhoToolStripMenuItem.Visible = false;
                tạoHóaĐơnToolStripMenuItem.Visible = false;
                btnXemDoanhThu.Visible = false;
            }
        }



        private void QuảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhachHang f = new fQuanLyKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }



        private void lậpPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXuatKho f = new fXuatKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lậpPhiếuNhậpKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fNhapKho f = new fNhapKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemDoanhThu f = new fXemDoanhThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
