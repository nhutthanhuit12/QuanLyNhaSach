namespace QuanLyNhaSach.GUI
{
    partial class fNhapKho
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
            btnPheDuyet = new Button();
            btnXoaNK = new Button();
            btnThemNK = new Button();
            txbTongTien = new TextBox();
            label9 = new Label();
            dtpkNgayNhap = new DateTimePicker();
            label7 = new Label();
            txbMaThuKho = new TextBox();
            txbNhaCungCap = new TextBox();
            txbMaNhapKho = new TextBox();
            label6 = new Label();
            cbTenThuKho = new ComboBox();
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
            label12 = new Label();
            dgvCTNhapKho = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label5 = new Label();
            dgvNhapKho = new DataGridView();
            MaNK = new DataGridViewTextBoxColumn();
            TenThuKho = new DataGridViewTextBoxColumn();
            NhaCC = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTNhapKho).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 41);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 5);
            label1.Name = "label1";
            label1.Size = new Size(149, 36);
            label1.TabIndex = 0;
            label1.Text = "Nhập kho";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPheDuyet);
            panel2.Controls.Add(btnXoaNK);
            panel2.Controls.Add(btnThemNK);
            panel2.Controls.Add(txbTongTien);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dtpkNgayNhap);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbMaThuKho);
            panel2.Controls.Add(txbNhaCungCap);
            panel2.Controls.Add(txbMaNhapKho);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbTenThuKho);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(1134, 91);
            panel2.TabIndex = 2;
            // 
            // btnPheDuyet
            // 
            btnPheDuyet.Location = new Point(736, 47);
            btnPheDuyet.Name = "btnPheDuyet";
            btnPheDuyet.Size = new Size(118, 30);
            btnPheDuyet.TabIndex = 22;
            btnPheDuyet.Text = "Phê duyệt";
            btnPheDuyet.UseVisualStyleBackColor = true;
            btnPheDuyet.Click += btnPheDuyet_Click;
            // 
            // btnXoaNK
            // 
            btnXoaNK.Location = new Point(657, 47);
            btnXoaNK.Name = "btnXoaNK";
            btnXoaNK.Size = new Size(73, 30);
            btnXoaNK.TabIndex = 21;
            btnXoaNK.Text = "Xóa";
            btnXoaNK.UseVisualStyleBackColor = true;
            btnXoaNK.Click += btnXoaNK_Click;
            // 
            // btnThemNK
            // 
            btnThemNK.Location = new Point(578, 47);
            btnThemNK.Name = "btnThemNK";
            btnThemNK.Size = new Size(73, 30);
            btnThemNK.TabIndex = 20;
            btnThemNK.Text = "Thêm";
            btnThemNK.UseVisualStyleBackColor = true;
            btnThemNK.Click += btnThemNK_Click;
            // 
            // txbTongTien
            // 
            txbTongTien.BackColor = SystemColors.Window;
            txbTongTien.Location = new Point(860, 9);
            txbTongTien.Name = "txbTongTien";
            txbTongTien.ReadOnly = true;
            txbTongTien.Size = new Size(150, 30);
            txbTongTien.TabIndex = 19;
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
            // dtpkNgayNhap
            // 
            dtpkNgayNhap.Format = DateTimePickerFormat.Short;
            dtpkNgayNhap.Location = new Point(122, 51);
            dtpkNgayNhap.Name = "dtpkNgayNhap";
            dtpkNgayNhap.Size = new Size(80, 30);
            dtpkNgayNhap.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 51);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 15;
            label7.Text = "Ngày nhập";
            // 
            // txbMaThuKho
            // 
            txbMaThuKho.BackColor = SystemColors.Window;
            txbMaThuKho.Location = new Point(330, 9);
            txbMaThuKho.Name = "txbMaThuKho";
            txbMaThuKho.ReadOnly = true;
            txbMaThuKho.Size = new Size(135, 30);
            txbMaThuKho.TabIndex = 14;
            // 
            // txbNhaCungCap
            // 
            txbNhaCungCap.Location = new Point(617, 9);
            txbNhaCungCap.Name = "txbNhaCungCap";
            txbNhaCungCap.Size = new Size(135, 30);
            txbNhaCungCap.TabIndex = 13;
            // 
            // txbMaNhapKho
            // 
            txbMaNhapKho.BackColor = SystemColors.Window;
            txbMaNhapKho.Location = new Point(122, 9);
            txbMaNhapKho.Name = "txbMaNhapKho";
            txbMaNhapKho.ReadOnly = true;
            txbMaNhapKho.Size = new Size(80, 30);
            txbMaNhapKho.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 54);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 9;
            label6.Text = "Tên thủ kho";
            // 
            // cbTenThuKho
            // 
            cbTenThuKho.FormattingEnabled = true;
            cbTenThuKho.Location = new Point(330, 51);
            cbTenThuKho.Name = "cbTenThuKho";
            cbTenThuKho.Size = new Size(181, 30);
            cbTenThuKho.TabIndex = 8;
            cbTenThuKho.SelectedIndexChanged += cbTenThuKho_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 12);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 5;
            label4.Text = "Mã thủ kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 12);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 3;
            label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã nhập kho";
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
            panel3.Size = new Size(1134, 178);
            panel3.TabIndex = 3;
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
            nmrSoLuong.Location = new Point(97, 95);
            nmrSoLuong.Name = "nmrSoLuong";
            nmrSoLuong.Size = new Size(70, 30);
            nmrSoLuong.TabIndex = 6;
            // 
            // cbTenSach
            // 
            cbTenSach.FormattingEnabled = true;
            cbTenSach.Location = new Point(99, 54);
            cbTenSach.Name = "cbTenSach";
            cbTenSach.Size = new Size(132, 30);
            cbTenSach.TabIndex = 5;
            cbTenSach.SelectedIndexChanged += cbTenSach_SelectedIndexChanged;
            // 
            // txbMaSach
            // 
            txbMaSach.BackColor = SystemColors.Window;
            txbMaSach.Location = new Point(99, 13);
            txbMaSach.Name = "txbMaSach";
            txbMaSach.ReadOnly = true;
            txbMaSach.Size = new Size(70, 30);
            txbMaSach.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 97);
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
            label8.Location = new Point(9, 57);
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
            dgvSach.Location = new Point(339, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 62;
            dgvSach.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(795, 178);
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
            SoLuong.DataPropertyName = "SoLuong";
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
            ThanhTien.Width = 200;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(dgvCTNhapKho);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 609);
            panel4.Name = "panel4";
            panel4.Size = new Size(1134, 233);
            panel4.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.OldLace;
            label12.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(475, 4);
            label12.Name = "label12";
            label12.Size = new Size(154, 23);
            label12.TabIndex = 3;
            label12.Text = "Chi tiết nhập kho";
            // 
            // dgvCTNhapKho
            // 
            dgvCTNhapKho.AllowUserToAddRows = false;
            dgvCTNhapKho.AllowUserToDeleteRows = false;
            dgvCTNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTNhapKho.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvCTNhapKho.Location = new Point(0, 29);
            dgvCTNhapKho.Name = "dgvCTNhapKho";
            dgvCTNhapKho.RowHeadersVisible = false;
            dgvCTNhapKho.RowHeadersWidth = 62;
            dgvCTNhapKho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCTNhapKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTNhapKho.Size = new Size(1134, 204);
            dgvCTNhapKho.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn6.HeaderText = "Mã sách ";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn7.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 350;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn8.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "GiaGoc";
            dataGridViewTextBoxColumn9.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "ThanhTien";
            dataGridViewTextBoxColumn10.HeaderText = "Thành tiền";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 250;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dgvNhapKho);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 310);
            panel5.Name = "panel5";
            panel5.Size = new Size(1134, 300);
            panel5.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OldLace;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 6);
            label5.Name = "label5";
            label5.Size = new Size(177, 23);
            label5.TabIndex = 2;
            label5.Text = "Danh sách nhập kho";
            // 
            // dgvNhapKho
            // 
            dgvNhapKho.AllowUserToAddRows = false;
            dgvNhapKho.AllowUserToDeleteRows = false;
            dgvNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapKho.Columns.AddRange(new DataGridViewColumn[] { MaNK, TenThuKho, NhaCC, TongTien, Column1 });
            dgvNhapKho.Location = new Point(0, 31);
            dgvNhapKho.Name = "dgvNhapKho";
            dgvNhapKho.ReadOnly = true;
            dgvNhapKho.RowHeadersVisible = false;
            dgvNhapKho.RowHeadersWidth = 62;
            dgvNhapKho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvNhapKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapKho.Size = new Size(1134, 269);
            dgvNhapKho.TabIndex = 1;
            dgvNhapKho.CellClick += dgvNhapKho_CellClick;
            // 
            // MaNK
            // 
            MaNK.DataPropertyName = "MaNK";
            MaNK.HeaderText = "Mã nhập kho";
            MaNK.MinimumWidth = 8;
            MaNK.Name = "MaNK";
            MaNK.ReadOnly = true;
            MaNK.Width = 150;
            // 
            // TenThuKho
            // 
            TenThuKho.DataPropertyName = "TenThuKho";
            TenThuKho.HeaderText = "Tên thủ kho";
            TenThuKho.MinimumWidth = 8;
            TenThuKho.Name = "TenThuKho";
            TenThuKho.ReadOnly = true;
            TenThuKho.Width = 300;
            // 
            // NhaCC
            // 
            NhaCC.DataPropertyName = "NhaCC";
            NhaCC.HeaderText = "Nhà cung cấp";
            NhaCC.MinimumWidth = 8;
            NhaCC.Name = "NhaCC";
            NhaCC.ReadOnly = true;
            NhaCC.Width = 300;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Width = 260;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TTDuyet";
            Column1.HeaderText = "Trạng thái";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // fNhapKho
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 842);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fNhapKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập kho";
            Load += fNhapKho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTNhapKho).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnXoaNK;
        private Button btnThemNK;
        private TextBox txbTongTien;
        private Label label9;
        private DateTimePicker dtpkNgayNhap;
        private Label label7;
        private TextBox txbMaThuKho;
        private TextBox txbNhaCungCap;
        private TextBox txbMaNhapKho;
        private Label label6;
        private ComboBox cbTenThuKho;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnXoaSach;
        private Button btnThemSach;
        private NumericUpDown nmrSoLuong;
        private ComboBox cbTenSach;
        private TextBox txbMaSach;
        private Label label11;
        private Label label10;
        private Label label8;
        private DataGridView dgvSach;
        private Panel panel4;
        private DataGridView dgvCTNhapKho;
        private Panel panel5;
        private DataGridView dgvNhapKho;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnPheDuyet;
        private Label label5;
        private DataGridViewTextBoxColumn MaNK;
        private DataGridViewTextBoxColumn TenThuKho;
        private DataGridViewTextBoxColumn NhaCC;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn Column1;
        private Label label12;
    }
}