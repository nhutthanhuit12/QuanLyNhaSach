namespace QuanLyNhaSach.GUI
{
    partial class fHoaDon
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
            label1 = new Label();
            panel2 = new Panel();
            btnTaoHoaDon = new Button();
            txbTongTien = new TextBox();
            btnSuaHoaDon = new Button();
            btnXoaHoaDon = new Button();
            btnThemHoaDon = new Button();
            label9 = new Label();
            dtpkNgayLap = new DateTimePicker();
            label7 = new Label();
            txbMaNhanVien = new TextBox();
            txbMaKhachHang = new TextBox();
            txbMaHoaDon = new TextBox();
            label6 = new Label();
            cbTenNhanVien = new ComboBox();
            label5 = new Label();
            cbTenKhachHang = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnXoaSach = new Button();
            btnThemSach = new Button();
            nmrSoLuong = new NumericUpDown();
            cbTenSach = new ComboBox();
            txbMaSach = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            dgvSach = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            dgvHoaDon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dgvCTHD = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(493, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 36);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTaoHoaDon);
            panel2.Controls.Add(txbTongTien);
            panel2.Controls.Add(btnSuaHoaDon);
            panel2.Controls.Add(btnXoaHoaDon);
            panel2.Controls.Add(btnThemHoaDon);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dtpkNgayLap);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbMaNhanVien);
            panel2.Controls.Add(txbMaKhachHang);
            panel2.Controls.Add(txbMaHoaDon);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbTenNhanVien);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbTenKhachHang);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 91);
            panel2.TabIndex = 1;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(1027, 45);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(73, 34);
            btnTaoHoaDon.TabIndex = 23;
            btnTaoHoaDon.Text = "Tạo";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // txbTongTien
            // 
            txbTongTien.BackColor = SystemColors.Window;
            txbTongTien.Location = new Point(860, 9);
            txbTongTien.Name = "txbTongTien";
            txbTongTien.ReadOnly = true;
            txbTongTien.Size = new Size(135, 30);
            txbTongTien.TabIndex = 7;
            // 
            // btnSuaHoaDon
            // 
            btnSuaHoaDon.Location = new Point(948, 45);
            btnSuaHoaDon.Name = "btnSuaHoaDon";
            btnSuaHoaDon.Size = new Size(73, 34);
            btnSuaHoaDon.TabIndex = 22;
            btnSuaHoaDon.Text = "Sửa";
            btnSuaHoaDon.UseVisualStyleBackColor = true;
            btnSuaHoaDon.Click += btnSuaHoaDon_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Location = new Point(869, 45);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(73, 34);
            btnXoaHoaDon.TabIndex = 21;
            btnXoaHoaDon.Text = "Xóa";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // btnThemHoaDon
            // 
            btnThemHoaDon.Location = new Point(790, 47);
            btnThemHoaDon.Name = "btnThemHoaDon";
            btnThemHoaDon.Size = new Size(73, 34);
            btnThemHoaDon.TabIndex = 20;
            btnThemHoaDon.Text = "Thêm";
            btnThemHoaDon.UseVisualStyleBackColor = true;
            btnThemHoaDon.Click += btnThemHoaDon_Click_;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(770, 12);
            label9.Name = "label9";
            label9.Size = new Size(84, 22);
            label9.TabIndex = 18;
            label9.Text = "Tổng tiền";
            // 
            // dtpkNgayLap
            // 
            dtpkNgayLap.Format = DateTimePickerFormat.Short;
            dtpkNgayLap.Location = new Point(122, 51);
            dtpkNgayLap.Name = "dtpkNgayLap";
            dtpkNgayLap.Size = new Size(80, 30);
            dtpkNgayLap.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 51);
            label7.Name = "label7";
            label7.Size = new Size(81, 22);
            label7.TabIndex = 15;
            label7.Text = "Ngày lập";
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.BackColor = SystemColors.Window;
            txbMaNhanVien.Location = new Point(330, 9);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.ReadOnly = true;
            txbMaNhanVien.Size = new Size(135, 30);
            txbMaNhanVien.TabIndex = 14;
            // 
            // txbMaKhachHang
            // 
            txbMaKhachHang.BackColor = SystemColors.Window;
            txbMaKhachHang.Location = new Point(617, 9);
            txbMaKhachHang.Name = "txbMaKhachHang";
            txbMaKhachHang.ReadOnly = true;
            txbMaKhachHang.Size = new Size(135, 30);
            txbMaKhachHang.TabIndex = 13;
            // 
            // txbMaHoaDon
            // 
            txbMaHoaDon.BackColor = SystemColors.Window;
            txbMaHoaDon.Location = new Point(122, 9);
            txbMaHoaDon.Name = "txbMaHoaDon";
            txbMaHoaDon.ReadOnly = true;
            txbMaHoaDon.Size = new Size(80, 30);
            txbMaHoaDon.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 51);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 9;
            label6.Text = "Tên nhân viên";
            // 
            // cbTenNhanVien
            // 
            cbTenNhanVien.FormattingEnabled = true;
            cbTenNhanVien.Location = new Point(330, 51);
            cbTenNhanVien.Name = "cbTenNhanVien";
            cbTenNhanVien.Size = new Size(135, 30);
            cbTenNhanVien.TabIndex = 8;
            cbTenNhanVien.SelectedIndexChanged += cbTenNhanVien_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 51);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 7;
            label5.Text = "Tên khách hàng";
            // 
            // cbTenKhachHang
            // 
            cbTenKhachHang.FormattingEnabled = true;
            cbTenKhachHang.Location = new Point(617, 51);
            cbTenKhachHang.Name = "cbTenKhachHang";
            cbTenKhachHang.Size = new Size(135, 30);
            cbTenKhachHang.TabIndex = 6;
            cbTenKhachHang.SelectedIndexChanged += cbTenKhachHang_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 15);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 5;
            label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 12);
            label3.Name = "label3";
            label3.Size = new Size(127, 22);
            label3.TabIndex = 3;
            label3.Text = "Mã khách hàng\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã hóa đơn";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXoaSach);
            panel3.Controls.Add(btnThemSach);
            panel3.Controls.Add(nmrSoLuong);
            panel3.Controls.Add(cbTenSach);
            panel3.Controls.Add(txbMaSach);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dgvSach);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 178);
            panel3.TabIndex = 2;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Location = new Point(103, 141);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(85, 34);
            btnXoaSach.TabIndex = 8;
            btnXoaSach.Text = "Xóa";
            btnXoaSach.UseVisualStyleBackColor = true;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.Location = new Point(12, 141);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(85, 34);
            btnThemSach.TabIndex = 7;
            btnThemSach.Text = "Thêm";
            btnThemSach.UseVisualStyleBackColor = true;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // nmrSoLuong
            // 
            nmrSoLuong.Location = new Point(99, 96);
            nmrSoLuong.Name = "nmrSoLuong";
            nmrSoLuong.Size = new Size(70, 30);
            nmrSoLuong.TabIndex = 6;
            // 
            // cbTenSach
            // 
            cbTenSach.FormattingEnabled = true;
            cbTenSach.Location = new Point(99, 54);
            cbTenSach.Name = "cbTenSach";
            cbTenSach.Size = new Size(195, 30);
            cbTenSach.TabIndex = 5;
            cbTenSach.SelectedIndexChanged += cbTenSach_SelectedIndexChanged;
            // 
            // txbMaSach
            // 
            txbMaSach.BackColor = SystemColors.Window;
            txbMaSach.Location = new Point(99, 13);
            txbMaSach.Name = "txbMaSach";
            txbMaSach.ReadOnly = true;
            txbMaSach.Size = new Size(195, 30);
            txbMaSach.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 98);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 3;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 16);
            label10.Name = "label10";
            label10.Size = new Size(76, 22);
            label10.TabIndex = 2;
            label10.Text = "Mã sách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 54);
            label8.Name = "label8";
            label8.Size = new Size(80, 22);
            label8.TabIndex = 1;
            label8.Text = "Tên sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, SoLuong, DonGia, ThanhTien });
            dgvSach.Dock = DockStyle.Right;
            dgvSach.Location = new Point(300, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 62;
            dgvSach.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(832, 178);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách ";
            MaSach.MinimumWidth = 8;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            MaSach.Width = 150;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 8;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            TenSach.Width = 250;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 150;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            DonGia.Width = 150;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Width = 150;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvHoaDon);
            panel4.Controls.Add(dgvCTHD);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 310);
            panel4.Name = "panel4";
            panel4.Size = new Size(1132, 501);
            panel4.TabIndex = 3;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1132, 353);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaHD";
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaKH";
            Column2.HeaderText = "Mã khách hàng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenKH";
            Column3.HeaderText = "Tên khách hàng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MaNV";
            Column4.HeaderText = "Mã nhân viên";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TenNhanVien";
            Column5.HeaderText = "Tên nhân viên";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 250;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "NgayLap";
            Column6.HeaderText = "Ngày lập";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TongTien";
            Column7.HeaderText = "Tổng tiền";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvCTHD.Dock = DockStyle.Bottom;
            dgvCTHD.Location = new Point(0, 353);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.ReadOnly = true;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 62;
            dgvCTHD.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTHD.Size = new Size(1132, 148);
            dgvCTHD.TabIndex = 1;
            dgvCTHD.CellContentClick += dgvCTHD_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn1.HeaderText = "Mã sách ";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DonGia";
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ThanhTien";
            dataGridViewTextBoxColumn5.HeaderText = "Thành tiền";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 300;
            // 
            // fHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 811);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox cbTenKhachHang;
        private Label label4;
        private Label label6;
        private ComboBox cbTenNhanVien;
        private DateTimePicker dtpkNgayLap;
        private Label label7;
        private TextBox txbMaNhanVien;
        private TextBox txbMaKhachHang;
        private TextBox txbMaHoaDon;
        private Label label9;
        private Panel panel3;
        private NumericUpDown nmrSoLuong;
        private ComboBox cbTenSach;
        private TextBox txbMaSach;
        private Label label11;
        private Label label10;
        private Label label8;
        private DataGridView dgvSach;
        private Button btnThemSach;
        private Button btnXoaSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnThemHoaDon;
        private Button btnSuaHoaDon;
        private Button btnXoaHoaDon;
        private Panel panel4;
        private DataGridView dgvCTHD;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TextBox txbTongTien;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnTaoHoaDon;
    }
}