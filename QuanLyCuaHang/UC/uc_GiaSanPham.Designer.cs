namespace QuanLyCuaHang
{
    partial class uc_GiaSanPham
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_giaTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_maSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_soLuong = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lbl_giaTien);
            this.guna2Panel1.Controls.Add(this.lbl_maSP);
            this.guna2Panel1.Controls.Add(this.lbl_soLuong);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(244, 29);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lbl_giaTien
            // 
            this.lbl_giaTien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_giaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.lbl_giaTien.Location = new System.Drawing.Point(185, 5);
            this.lbl_giaTien.Name = "lbl_giaTien";
            this.lbl_giaTien.Size = new System.Drawing.Size(34, 18);
            this.lbl_giaTien.TabIndex = 2;
            this.lbl_giaTien.Text = "Price";
            this.lbl_giaTien.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_maSP
            // 
            this.lbl_maSP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.lbl_maSP.Location = new System.Drawing.Point(53, 5);
            this.lbl_maSP.Name = "lbl_maSP";
            this.lbl_maSP.Size = new System.Drawing.Size(40, 18);
            this.lbl_maSP.TabIndex = 1;
            this.lbl_maSP.Text = "maSP";
            this.lbl_maSP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_soLuong
            // 
            this.lbl_soLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.lbl_soLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soLuong.ForeColor = System.Drawing.Color.White;
            this.lbl_soLuong.Location = new System.Drawing.Point(20, 2);
            this.lbl_soLuong.Name = "lbl_soLuong";
            this.lbl_soLuong.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.lbl_soLuong.Size = new System.Drawing.Size(25, 25);
            this.lbl_soLuong.TabIndex = 0;
            this.lbl_soLuong.Text = "1";
            this.lbl_soLuong.TextChanged += new System.EventHandler(this.lbl_soLuong_TextChanged);
            // 
            // uc_GiaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_GiaSP";
            this.Size = new System.Drawing.Size(250, 35);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_giaTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_maSP;
        private Guna.UI2.WinForms.Guna2CircleButton lbl_soLuong;
    }
}
