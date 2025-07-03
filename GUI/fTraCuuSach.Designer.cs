namespace QuanLyNhaSach.GUI
{
    partial class fTraCuuSach
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
            txbGiaBan = new TextBox();
            txbGiaGoc = new TextBox();
            btnTimKiem = new Button();
            txbDaBan = new TextBox();
            label6 = new Label();
            txbTonKho = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txbTacGia = new TextBox();
            label4 = new Label();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dtpkNgayXB = new DateTimePicker();
            txbTaiQuay = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txbNXB = new TextBox();
            label5 = new Label();
            txbTheLoai = new TextBox();
            label3 = new Label();
            txbTenSach = new TextBox();
            label2 = new Label();
            txbId = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvTraCuuSach = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTraCuuSach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbGiaBan);
            panel1.Controls.Add(txbGiaGoc);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txbDaBan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbTonKho);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txbTacGia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dtpkNgayXB);
            panel1.Controls.Add(txbTaiQuay);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txbNXB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txbTheLoai);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbTenSach);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 160);
            panel1.TabIndex = 2;
            // 
            // txbGiaBan
            // 
            txbGiaBan.Location = new Point(882, 48);
            txbGiaBan.Name = "txbGiaBan";
            txbGiaBan.Size = new Size(150, 30);
            txbGiaBan.TabIndex = 51;
            // 
            // txbGiaGoc
            // 
            txbGiaGoc.Location = new Point(633, 50);
            txbGiaGoc.Name = "txbGiaGoc";
            txbGiaGoc.Size = new Size(150, 30);
            txbGiaGoc.TabIndex = 50;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1058, 92);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(68, 34);
            btnTimKiem.TabIndex = 49;
            btnTimKiem.TabStop = false;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txbDaBan
            // 
            txbDaBan.BackColor = SystemColors.Window;
            txbDaBan.Location = new Point(577, 96);
            txbDaBan.Name = "txbDaBan";
            txbDaBan.ReadOnly = true;
            txbDaBan.Size = new Size(150, 30);
            txbDaBan.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 99);
            label6.Name = "label6";
            label6.Size = new Size(66, 22);
            label6.TabIndex = 47;
            label6.Text = "Đã bán";
            // 
            // txbTonKho
            // 
            txbTonKho.BackColor = SystemColors.Window;
            txbTonKho.Location = new Point(347, 96);
            txbTonKho.Name = "txbTonKho";
            txbTonKho.ReadOnly = true;
            txbTonKho.Size = new Size(150, 30);
            txbTonKho.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(262, 99);
            label12.Name = "label12";
            label12.Size = new Size(74, 22);
            label12.TabIndex = 45;
            label12.Text = "Tồn kho";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(804, 51);
            label11.Name = "label11";
            label11.Size = new Size(72, 22);
            label11.TabIndex = 43;
            label11.Text = "Giá bán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(564, 53);
            label10.Name = "label10";
            label10.Size = new Size(72, 22);
            label10.TabIndex = 41;
            label10.Text = "Giá gốc";
            // 
            // txbTacGia
            // 
            txbTacGia.Location = new Point(755, 6);
            txbTacGia.Name = "txbTacGia";
            txbTacGia.Size = new Size(201, 30);
            txbTacGia.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 7);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 40;
            label4.Text = "Tác giả";
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(970, 93);
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
            btnSua.Location = new Point(896, 93);
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
            btnXoa.Location = new Point(822, 93);
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
            btnThem.Location = new Point(748, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(68, 34);
            btnThem.TabIndex = 35;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpkNgayXB
            // 
            dtpkNgayXB.Format = DateTimePickerFormat.Short;
            dtpkNgayXB.Location = new Point(406, 50);
            dtpkNgayXB.Name = "dtpkNgayXB";
            dtpkNgayXB.Size = new Size(120, 30);
            dtpkNgayXB.TabIndex = 5;
            // 
            // txbTaiQuay
            // 
            txbTaiQuay.BackColor = SystemColors.Window;
            txbTaiQuay.Location = new Point(91, 96);
            txbTaiQuay.Name = "txbTaiQuay";
            txbTaiQuay.ReadOnly = true;
            txbTaiQuay.Size = new Size(150, 30);
            txbTaiQuay.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 99);
            label9.Name = "label9";
            label9.Size = new Size(79, 22);
            label9.TabIndex = 23;
            label9.Text = "Tại quầy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(577, 53);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 53);
            label7.Name = "label7";
            label7.Size = new Size(121, 22);
            label7.TabIndex = 26;
            label7.Text = "Ngày xuất bản";
            // 
            // txbNXB
            // 
            txbNXB.Location = new Point(60, 50);
            txbNXB.Name = "txbNXB";
            txbNXB.Size = new Size(191, 30);
            txbNXB.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 29;
            label5.Text = "NXB";
            // 
            // txbTheLoai
            // 
            txbTheLoai.Location = new Point(515, 6);
            txbTheLoai.Name = "txbTheLoai";
            txbTheLoai.Size = new Size(150, 30);
            txbTheLoai.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 32;
            label3.Text = "Thể loại";
            // 
            // txbTenSach
            // 
            txbTenSach.Location = new Point(222, 6);
            txbTenSach.Name = "txbTenSach";
            txbTenSach.Size = new Size(194, 30);
            txbTenSach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 7);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 33;
            label2.Text = "Tên sách";
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
            // panel2
            // 
            panel2.Controls.Add(dgvTraCuuSach);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 512);
            panel2.TabIndex = 3;
            // 
            // dgvTraCuuSach
            // 
            dgvTraCuuSach.AllowUserToAddRows = false;
            dgvTraCuuSach.AllowUserToDeleteRows = false;
            dgvTraCuuSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraCuuSach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dgvTraCuuSach.Dock = DockStyle.Fill;
            dgvTraCuuSach.Location = new Point(0, 0);
            dgvTraCuuSach.Name = "dgvTraCuuSach";
            dgvTraCuuSach.RowHeadersVisible = false;
            dgvTraCuuSach.RowHeadersWidth = 62;
            dgvTraCuuSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTraCuuSach.Size = new Size(1129, 512);
            dgvTraCuuSach.TabIndex = 0;
            dgvTraCuuSach.CellClick += dgvTraCuuSach_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaSach";
            Column1.HeaderText = "Mã sách";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenSach";
            Column2.HeaderText = "Tên sách";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TheLoai";
            Column3.HeaderText = "Thể loại";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TacGia";
            Column4.HeaderText = "Tác giả";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "NXB";
            Column5.HeaderText = "NXB";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "NgayXB";
            Column6.HeaderText = "Ngày xuất bản";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "GiaGoc";
            Column7.HeaderText = "Giá gốc";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 70;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "GiaBan";
            Column8.HeaderText = "Giá bán";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 70;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "TaiQuay";
            Column9.HeaderText = "Tại quầy";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 70;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "TonKho";
            Column10.HeaderText = "Tồn kho";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 70;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "DaBan";
            Column11.HeaderText = "Đã bán";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Width = 70;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // fTraCuuSach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 672);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fTraCuuSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tra cứu sách";
            Load += fTraCuuSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTraCuuSach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox cbLoaiTaiKhoan;
        private Button btnTaiLai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DateTimePicker dtpkNgayXB;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private TextBox txbTaiQuay;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txbNXB;
        private Label label5;
        private TextBox txbTheLoai;
        private Label label3;
        private TextBox txbTenSach;
        private Label label2;
        private TextBox txbId;
        private Label label1;
        private TextBox txbTacGia;
        private Label label4;
        private TextBox txbTonKho;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txbDaBan;
        private Panel panel2;
        private DataGridView dgvTraCuuSach;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Button btnTimKiem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txbGiaBan;
        private TextBox txbGiaGoc;
    }
}