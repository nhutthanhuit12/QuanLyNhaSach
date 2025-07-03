namespace QuanLyNhaSach.Report
{
    partial class rHoaDon
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
            stivcHoaDon = new Stimulsoft.Report.Viewer.StiViewerControl();
            SuspendLayout();
            // 
            // stivcHoaDon
            // 
            stivcHoaDon.AllowDrop = true;
            stivcHoaDon.Dock = DockStyle.Fill;
            stivcHoaDon.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stivcHoaDon.Location = new Point(0, 0);
            stivcHoaDon.Margin = new Padding(6, 5, 6, 5);
            stivcHoaDon.Name = "stivcHoaDon";
            stivcHoaDon.Report = null;
            stivcHoaDon.RightToLeft = RightToLeft.No;
            stivcHoaDon.ShowZoom = true;
            stivcHoaDon.Size = new Size(964, 667);
            stivcHoaDon.TabIndex = 0;
            // 
            // rHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 667);
            Controls.Add(stivcHoaDon);
            Name = "rHoaDon";
            Text = "rHoaDon";
            ResumeLayout(false);
        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl stivcHoaDon;
    }
}