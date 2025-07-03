namespace QuanLyNhaSach.GUI
{
    partial class fQuanLyKhachHang
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
            panel1 = new Panel();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            txbSDT = new TextBox();
            label9 = new Label();
            txbDiaChi = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txbTenKhachHang = new TextBox();
            label2 = new Label();
            txbId = new TextBox();
            label1 = new Label();
            dgvKhachHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(txbSDT);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txbDiaChi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbTenKhachHang);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 105);
            panel1.TabIndex = 2;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(862, 47);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(85, 34);
            btnTaiLai.TabIndex = 38;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(788, 48);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(68, 34);
            btnSua.TabIndex = 37;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(705, 47);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(68, 34);
            btnXoa.TabIndex = 36;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(621, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(68, 34);
            btnThem.TabIndex = 35;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(729, 7);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(60, 26);
            rdNu.TabIndex = 20;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(651, 7);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(72, 26);
            rdNam.TabIndex = 5;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(398, 51);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(161, 30);
            txbSDT.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(345, 54);
            label9.Name = "label9";
            label9.Size = new Size(47, 22);
            label9.TabIndex = 23;
            label9.Text = "SĐT";
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(77, 51);
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.Size = new Size(224, 30);
            txbDiaChi.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 54);
            label8.Name = "label8";
            label8.Size = new Size(68, 22);
            label8.TabIndex = 25;
            label8.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(564, 11);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 27;
            label6.Text = "Giới tính";
            // 
            // txbTenKhachHang
            // 
            txbTenKhachHang.Location = new Point(266, 6);
            txbTenKhachHang.Name = "txbTenKhachHang";
            txbTenKhachHang.Size = new Size(261, 30);
            txbTenKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 7);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 33;
            label2.Text = "Tên khách hàng\r\n";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 34;
            label1.Text = "ID";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 105);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.RowTemplate.Height = 30;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(952, 475);
            dgvKhachHang.TabIndex = 3;
            dgvKhachHang.TabStop = false;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaKH";
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenKH";
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "GioiTinh";
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DiaChi";
            Column4.HeaderText = "Địa chỉ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoDT";
            Column5.HeaderText = "SĐT";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TongTienChi";
            Column6.HeaderText = "Tổng tiền chi";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 230;
            // 
            // fQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 580);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fQuanLyKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += fQuanLyKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTaiLai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private TextBox txbSDT;
        private Label label9;
        private TextBox txbDiaChi;
        private Label label8;
        private Label label6;
        private TextBox txbTenKhachHang;
        private Label label2;
        private TextBox txbId;
        private Label label1;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}