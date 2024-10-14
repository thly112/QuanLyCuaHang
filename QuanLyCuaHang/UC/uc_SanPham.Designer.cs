namespace QuanLyCuaHang
{
    partial class uc_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_giaTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_Product = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ptb_anhSanPham = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_giaTien
            // 
            this.lbl_giaTien.AutoSize = false;
            this.lbl_giaTien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_giaTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_giaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.lbl_giaTien.Location = new System.Drawing.Point(0, 167);
            this.lbl_giaTien.Name = "lbl_giaTien";
            this.lbl_giaTien.Size = new System.Drawing.Size(159, 15);
            this.lbl_giaTien.TabIndex = 2;
            this.lbl_giaTien.Text = "Price";
            this.lbl_giaTien.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_Product
            // 
            this.panel_Product.BackColor = System.Drawing.Color.White;
            this.panel_Product.BorderRadius = 20;
            this.panel_Product.Controls.Add(this.lbl_giaTien);
            this.panel_Product.Controls.Add(this.ptb_anhSanPham);
            this.panel_Product.Location = new System.Drawing.Point(3, 3);
            this.panel_Product.Name = "panel_Product";
            this.panel_Product.Size = new System.Drawing.Size(159, 182);
            this.panel_Product.TabIndex = 1;
            // 
            // ptb_anhSanPham
            // 
            this.ptb_anhSanPham.ImageRotate = 0F;
            this.ptb_anhSanPham.Location = new System.Drawing.Point(3, 3);
            this.ptb_anhSanPham.Name = "ptb_anhSanPham";
            this.ptb_anhSanPham.Size = new System.Drawing.Size(153, 158);
            this.ptb_anhSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_anhSanPham.TabIndex = 1;
            this.ptb_anhSanPham.TabStop = false;
            this.ptb_anhSanPham.Click += new System.EventHandler(this.ptb_anhSanPham_Click);
            // 
            // uc_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.Controls.Add(this.panel_Product);
            this.Name = "uc_SP";
            this.Size = new System.Drawing.Size(165, 188);
            this.panel_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_giaTien;
        private Guna.UI2.WinForms.Guna2GradientPanel panel_Product;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_anhSanPham;
    }
}
