using QuanLyNhaSach.BLL;

namespace QuanLyNhaSach
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;

            if(BLL_TaiKhoan.Instance.DangNhap(ten, matKhau))
            {
                fQuanLyNhaSach f = new fQuanLyNhaSach();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
