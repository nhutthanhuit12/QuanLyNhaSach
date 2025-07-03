namespace QuanLyNhaSach
{
    partial class fDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txbMatKhau = new TextBox();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txbMatKhau);
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 356);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(163, 235);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(163, 182);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(112, 34);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(163, 109);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(264, 30);
            txbMatKhau.TabIndex = 3;
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(163, 50);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(264, 30);
            txbTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 117);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // fDangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 369);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fDangNhap_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txbMatKhau;
        private TextBox txbTenDangNhap;
    }
}
