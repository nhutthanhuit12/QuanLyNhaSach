namespace QuanLyNhaSach
{
    partial class fQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            dgvTaiKhoan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txbId = new TextBox();
            label2 = new Label();
            txbTenDangNhap = new TextBox();
            label3 = new Label();
            txbMatKhau = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txbTenNguoiDung = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txbDiaChi = new TextBox();
            label9 = new Label();
            txbSDT = new TextBox();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            dtpkNgaySinh = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTaiLai = new Button();
            panel1 = new Panel();
            cbLoaiTaiKhoan = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 430);
            panel2.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.RowTemplate.Height = 30;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(952, 430);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.TabStop = false;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaTK";
            Column1.HeaderText = "Mã tài khoản";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenDangNhap";
            Column2.HeaderText = "Tên đăng nhập";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MatKhau";
            Column3.HeaderText = "Mật khẩu";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "LoaiTaiKhoan";
            Column4.HeaderText = "Loại tài khoản";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TenNguoiDung";
            Column5.HeaderText = "Tên người dùng";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "GioiTinh";
            Column6.HeaderText = "Giới tính";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NgaySinh";
            Column7.HeaderText = "Ngày sinh";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "DiaChi";
            Column8.HeaderText = "Địa chỉ";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "SoDT";
            Column9.HeaderText = "SĐT";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 34;
            label1.Text = "ID";
            // 
            // txbId
            // 
            txbId.BackColor = SystemColors.Window;
            txbId.Location = new Point(39, 6);
            txbId.Name = "txbId";
            txbId.ReadOnly = true;
            txbId.Size = new Size(77, 30);
            txbId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 7);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 33;
            label2.Text = "Tên đăng nhập";
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(266, 6);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(150, 30);
            txbTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 32;
            label3.Text = "Mật khẩu";
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(515, 6);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(150, 30);
            txbMatKhau.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(671, 11);
            label4.Name = "label4";
            label4.Size = new Size(46, 22);
            label4.TabIndex = 31;
            label4.Text = "Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(134, 22);
            label5.TabIndex = 29;
            label5.Text = "Tên người dùng";
            // 
            // txbTenNguoiDung
            // 
            txbTenNguoiDung.Location = new Point(133, 50);
            txbTenNguoiDung.Name = "txbTenNguoiDung";
            txbTenNguoiDung.Size = new Size(150, 30);
            txbTenNguoiDung.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 51);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 27;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(547, 50);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 26;
            label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 95);
            label8.Name = "label8";
            label8.Size = new Size(68, 22);
            label8.TabIndex = 25;
            label8.Text = "Địa chỉ";
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(77, 92);
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.Size = new Size(150, 30);
            txbDiaChi.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(248, 95);
            label9.Name = "label9";
            label9.Size = new Size(47, 22);
            label9.TabIndex = 23;
            label9.Text = "SĐT";
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(292, 92);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(150, 30);
            txbSDT.TabIndex = 8;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(381, 50);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(72, 26);
            rdNam.TabIndex = 5;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(459, 49);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(60, 26);
            rdNu.TabIndex = 20;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(641, 47);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(122, 30);
            dtpkNgaySinh.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(503, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(68, 34);
            btnThem.TabIndex = 35;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(577, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(68, 34);
            btnXoa.TabIndex = 36;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(651, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(68, 34);
            btnSua.TabIndex = 37;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(725, 92);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(85, 34);
            btnTaiLai.TabIndex = 38;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbLoaiTaiKhoan);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dtpkNgaySinh);
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(txbSDT);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txbDiaChi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbTenNguoiDung);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 150);
            panel1.TabIndex = 1;
            // 
            // cbLoaiTaiKhoan
            // 
            cbLoaiTaiKhoan.FormattingEnabled = true;
            cbLoaiTaiKhoan.Items.AddRange(new object[] { "Quản lý", "Thủ kho", "Nhân viên" });
            cbLoaiTaiKhoan.Location = new Point(725, 4);
            cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            cbLoaiTaiKhoan.Size = new Size(126, 30);
            cbLoaiTaiKhoan.TabIndex = 3;
            // 
            // fQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 580);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            Load += fQuanLyTaiKhoan_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dgvTaiKhoan;
        private Label label1;
        private TextBox txbId;
        private Label label2;
        private TextBox txbTenDangNhap;
        private Label label3;
        private TextBox txbMatKhau;
        private Label label4;
        private Label label5;
        private TextBox txbTenNguoiDung;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txbDiaChi;
        private Label label9;
        private TextBox txbSDT;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private DateTimePicker dtpkNgaySinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTaiLai;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private ComboBox cbLoaiTaiKhoan;
    }
}