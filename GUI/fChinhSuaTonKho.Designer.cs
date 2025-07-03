namespace QuanLyNhaSach.GUI
{
    partial class fChinhSuaTonKho
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
            label1 = new Label();
            nmrTonKho = new NumericUpDown();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrTonKho).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 47);
            label1.Name = "label1";
            label1.Size = new Size(213, 22);
            label1.TabIndex = 0;
            label1.Text = "Số lượng tồn kho tối thiểu";
            // 
            // nmrTonKho
            // 
            nmrTonKho.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nmrTonKho.Location = new Point(219, 45);
            nmrTonKho.Name = "nmrTonKho";
            nmrTonKho.Size = new Size(119, 30);
            nmrTonKho.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(128, 89);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(107, 30);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // fChinhSuaTonKho
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 129);
            Controls.Add(btnOK);
            Controls.Add(nmrTonKho);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fChinhSuaTonKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa tồn kho tối thiểu";
            ((System.ComponentModel.ISupportInitialize)nmrTonKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nmrTonKho;
        private Button btnOK;
    }
}