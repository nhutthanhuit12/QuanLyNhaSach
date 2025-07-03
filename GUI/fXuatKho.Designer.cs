namespace QuanLyNhaSach.GUI
{
    partial class fXuatKho
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
            btnTonKho = new Button();
            btnPheDuyet = new Button();
            btnXoaXK = new Button();
            btnThemXK = new Button();
            dtpkNgayXuat = new DateTimePicker();
            label7 = new Label();
            txbMaNhanVien = new TextBox();
            txbMaXuatKho = new TextBox();
            label6 = new Label();
            cbTenNhanVien = new ComboBox();
            label4 = new Label();
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
            panel5 = new Panel();
            label5 = new Label();
            dgvXuatKho = new DataGridView();
            MaXK = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label12 = new Label();
            dgvCTXuatKho = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXuatKho).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTXuatKho).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 41);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 5);
            label1.Name = "label1";
            label1.Size = new Size(142, 36);
            label1.TabIndex = 0;
            label1.Text = "Xuất kho";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTonKho);
            panel2.Controls.Add(btnPheDuyet);
            panel2.Controls.Add(btnXoaXK);
            panel2.Controls.Add(btnThemXK);
            panel2.Controls.Add(dtpkNgayXuat);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbMaNhanVien);
            panel2.Controls.Add(txbMaXuatKho);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbTenNhanVien);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(1134, 91);
            panel2.TabIndex = 3;
            // 
            // btnTonKho
            // 
            btnTonKho.Location = new Point(681, 54);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(234, 34);
            btnTonKho.TabIndex = 24;
            btnTonKho.Text = "Chỉnh sửa tồn kho tối thiểu";
            btnTonKho.UseVisualStyleBackColor = true;
            btnTonKho.Click += btnTonKho_Click;
            // 
            // btnPheDuyet
            // 
            btnPheDuyet.Location = new Point(865, 8);
            btnPheDuyet.Name = "btnPheDuyet";
            btnPheDuyet.Size = new Size(118, 30);
            btnPheDuyet.TabIndex = 23;
            btnPheDuyet.Text = "Phê duyệt";
            btnPheDuyet.UseVisualStyleBackColor = true;
            btnPheDuyet.Click += btnPheDuyet_Click;
            // 
            // btnXoaXK
            // 
            btnXoaXK.Location = new Point(773, 9);
            btnXoaXK.Name = "btnXoaXK";
            btnXoaXK.Size = new Size(86, 30);
            btnXoaXK.TabIndex = 21;
            btnXoaXK.Text = "Xóa";
            btnXoaXK.UseVisualStyleBackColor = true;
            btnXoaXK.Click += btnXoaXK_Click;
            // 
            // btnThemXK
            // 
            btnThemXK.Location = new Point(681, 11);
            btnThemXK.Name = "btnThemXK";
            btnThemXK.Size = new Size(86, 30);
            btnThemXK.TabIndex = 20;
            btnThemXK.Text = "Thêm";
            btnThemXK.UseVisualStyleBackColor = true;
            btnThemXK.Click += btnThemXK_Click;
            // 
            // dtpkNgayXuat
            // 
            dtpkNgayXuat.Format = DateTimePickerFormat.Short;
            dtpkNgayXuat.Location = new Point(122, 51);
            dtpkNgayXuat.Name = "dtpkNgayXuat";
            dtpkNgayXuat.Size = new Size(132, 30);
            dtpkNgayXuat.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 51);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 15;
            label7.Text = "Ngày xuất";
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.BackColor = SystemColors.Window;
            txbMaNhanVien.Location = new Point(462, 12);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.ReadOnly = true;
            txbMaNhanVien.Size = new Size(135, 30);
            txbMaNhanVien.TabIndex = 14;
            // 
            // txbMaXuatKho
            // 
            txbMaXuatKho.BackColor = SystemColors.Window;
            txbMaXuatKho.Location = new Point(122, 9);
            txbMaXuatKho.Name = "txbMaXuatKho";
            txbMaXuatKho.ReadOnly = true;
            txbMaXuatKho.Size = new Size(132, 30);
            txbMaXuatKho.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 51);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 9;
            label6.Text = "Tên nhân viên";
            // 
            // cbTenNhanVien
            // 
            cbTenNhanVien.FormattingEnabled = true;
            cbTenNhanVien.Location = new Point(462, 48);
            cbTenNhanVien.Name = "cbTenNhanVien";
            cbTenNhanVien.Size = new Size(181, 30);
            cbTenNhanVien.TabIndex = 8;
            cbTenNhanVien.SelectedIndexChanged += cbTenNhanVien_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 17);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 5;
            label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã xuất kho";
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
            panel3.TabIndex = 4;
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
            nmrSoLuong.Size = new Size(70, 31);
            nmrSoLuong.TabIndex = 6;
            // 
            // cbTenSach
            // 
            cbTenSach.FormattingEnabled = true;
            cbTenSach.Location = new Point(99, 54);
            cbTenSach.Name = "cbTenSach";
            cbTenSach.Size = new Size(195, 33);
            cbTenSach.TabIndex = 5;
            cbTenSach.SelectedIndexChanged += cbTenSach_SelectedIndexChanged;
            // 
            // txbMaSach
            // 
            txbMaSach.BackColor = SystemColors.Window;
            txbMaSach.Location = new Point(99, 13);
            txbMaSach.Name = "txbMaSach";
            txbMaSach.ReadOnly = true;
            txbMaSach.Size = new Size(195, 31);
            txbMaSach.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 98);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 3;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 16);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 2;
            label10.Text = "Mã sách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 54);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 1;
            label8.Text = "Tên sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, SoLuong });
            dgvSach.Dock = DockStyle.Right;
            dgvSach.Location = new Point(336, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 62;
            dgvSach.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(798, 178);
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
            TenSach.Width = 400;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 300;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dgvXuatKho);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 310);
            panel5.Name = "panel5";
            panel5.Size = new Size(1134, 300);
            panel5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OldLace;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 6);
            label5.Name = "label5";
            label5.Size = new Size(174, 23);
            label5.TabIndex = 2;
            label5.Text = "Danh sách xuất kho\r\n";
            // 
            // dgvXuatKho
            // 
            dgvXuatKho.AllowUserToAddRows = false;
            dgvXuatKho.AllowUserToDeleteRows = false;
            dgvXuatKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXuatKho.Columns.AddRange(new DataGridViewColumn[] { MaXK, TenNhanVien, Column1 });
            dgvXuatKho.Location = new Point(0, 31);
            dgvXuatKho.Name = "dgvXuatKho";
            dgvXuatKho.ReadOnly = true;
            dgvXuatKho.RowHeadersVisible = false;
            dgvXuatKho.RowHeadersWidth = 62;
            dgvXuatKho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvXuatKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXuatKho.Size = new Size(1134, 269);
            dgvXuatKho.TabIndex = 1;
            dgvXuatKho.CellClick += dgvXuatKho_CellClick;
            // 
            // MaXK
            // 
            MaXK.DataPropertyName = "MaXK";
            MaXK.HeaderText = "Mã xuất kho";
            MaXK.MinimumWidth = 8;
            MaXK.Name = "MaXK";
            MaXK.ReadOnly = true;
            MaXK.Width = 300;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 8;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            TenNhanVien.Width = 600;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TTDuyet";
            Column1.HeaderText = "Trạng thái";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 300;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(dgvCTXuatKho);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 557);
            panel4.Name = "panel4";
            panel4.Size = new Size(1134, 233);
            panel4.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.OldLace;
            label12.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(475, 4);
            label12.Name = "label12";
            label12.Size = new Size(151, 23);
            label12.TabIndex = 3;
            label12.Text = "Chi tiết xuất kho";
            // 
            // dgvCTXuatKho
            // 
            dgvCTXuatKho.AllowUserToAddRows = false;
            dgvCTXuatKho.AllowUserToDeleteRows = false;
            dgvCTXuatKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTXuatKho.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvCTXuatKho.Location = new Point(0, 29);
            dgvCTXuatKho.Name = "dgvCTXuatKho";
            dgvCTXuatKho.RowHeadersVisible = false;
            dgvCTXuatKho.RowHeadersWidth = 62;
            dgvCTXuatKho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCTXuatKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTXuatKho.Size = new Size(1134, 204);
            dgvCTXuatKho.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn6.HeaderText = "Mã sách ";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn7.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 600;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn8.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 300;
            // 
            // fXuatKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 790);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fXuatKho";
            Text = "Xuất kho";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXuatKho).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTXuatKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnXoaXK;
        private Button btnThemXK;
        private DateTimePicker dtpkNgayXuat;
        private Label label7;
        private TextBox txbMaNhanVien;
        private TextBox txbMaXuatKho;
        private Label label6;
        private ComboBox cbTenNhanVien;
        private Label label4;
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
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuong;
        private Panel panel5;
        private Label label5;
        private DataGridView dgvXuatKho;
        private DataGridViewTextBoxColumn MaXK;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn Column1;
        private Panel panel4;
        private Label label12;
        private DataGridView dgvCTXuatKho;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button btnPheDuyet;
        private Button btnTonKho;
    }
}