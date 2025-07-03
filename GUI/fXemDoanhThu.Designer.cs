namespace QuanLyNhaSach.GUI
{
    partial class fXemDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            btnXem = new Button();
            dtpkNgayKetThuc = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtpkNgayBatDau = new DateTimePicker();
            panel2 = new Panel();
            dgvHoaDon = new DataGridView();
            panel3 = new Panel();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXem);
            panel1.Controls.Add(dtpkNgayKetThuc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpkNgayBatDau);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 239);
            panel1.TabIndex = 0;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(60, 171);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(112, 34);
            btnXem.TabIndex = 4;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // dtpkNgayKetThuc
            // 
            dtpkNgayKetThuc.Location = new Point(0, 120);
            dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            dtpkNgayKetThuc.Size = new Size(245, 30);
            dtpkNgayKetThuc.TabIndex = 3;
            dtpkNgayKetThuc.Value = new DateTime(2025, 6, 12, 23, 59, 59, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 95);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày";
            // 
            // dtpkNgayBatDau
            // 
            dtpkNgayBatDau.Location = new Point(0, 53);
            dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            dtpkNgayBatDau.Size = new Size(245, 30);
            dtpkNgayBatDau.TabIndex = 0;
            dtpkNgayBatDau.Value = new DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHoaDon);
            panel2.Location = new Point(251, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 239);
            panel2.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { NgayLap, TongTien });
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(772, 239);
            dgvHoaDon.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartDoanhThu);
            panel3.Location = new Point(0, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 422);
            panel3.TabIndex = 2;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            chartDoanhThu.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(0, 0);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(1020, 422);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chart1";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày ";
            NgayLap.MinimumWidth = 8;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            NgayLap.Width = 500;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 8;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Width = 350;
            // 
            // fXemDoanhThu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 661);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fXemDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xem doanh thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpkNgayBatDau;
        private Panel panel2;
        private DataGridView dgvHoaDon;
        private Panel panel3;
        private DateTimePicker dtpkNgayKetThuc;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Button btnXem;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
    }
}