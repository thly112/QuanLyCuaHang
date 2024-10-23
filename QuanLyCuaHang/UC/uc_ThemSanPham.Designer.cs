namespace QuanLyCuaHang
{
    partial class uc_ThemSanPham
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
            this.cb_LoaiMatHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.num_soluong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cb_kichthuoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_giaban = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenmathang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TaiAnhLen = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pic_AnhMatHang = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_quaylai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_XacNhanThem = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quaylai)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_LoaiMatHang
            // 
            this.cb_LoaiMatHang.BackColor = System.Drawing.Color.Transparent;
            this.cb_LoaiMatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.cb_LoaiMatHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiMatHang.FocusedColor = System.Drawing.Color.Empty;
            this.cb_LoaiMatHang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiMatHang.ForeColor = System.Drawing.Color.Black;
            this.cb_LoaiMatHang.FormattingEnabled = true;
            this.cb_LoaiMatHang.ItemHeight = 30;
            this.cb_LoaiMatHang.Items.AddRange(new object[] {
            "Áo thun",
            "Áo khoác",
            "Áo sơ mi",
            "Áo polo",
            "Quần Jean",
            "Quần Tây",
            "Quần short"});
            this.cb_LoaiMatHang.Location = new System.Drawing.Point(448, 55);
            this.cb_LoaiMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LoaiMatHang.Name = "cb_LoaiMatHang";
            this.cb_LoaiMatHang.Size = new System.Drawing.Size(303, 36);
            this.cb_LoaiMatHang.TabIndex = 58;
            this.cb_LoaiMatHang.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiMatHang_SelectedIndexChanged);
            // 
            // num_soluong
            // 
            this.num_soluong.BackColor = System.Drawing.Color.Transparent;
            this.num_soluong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.num_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_soluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num_soluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num_soluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num_soluong.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num_soluong.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num_soluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num_soluong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_soluong.Location = new System.Drawing.Point(448, 511);
            this.num_soluong.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.num_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(164, 46);
            this.num_soluong.TabIndex = 57;
            this.num_soluong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            // 
            // cb_kichthuoc
            // 
            this.cb_kichthuoc.BackColor = System.Drawing.Color.Transparent;
            this.cb_kichthuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.cb_kichthuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_kichthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kichthuoc.FocusedColor = System.Drawing.Color.Empty;
            this.cb_kichthuoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_kichthuoc.ForeColor = System.Drawing.Color.Black;
            this.cb_kichthuoc.FormattingEnabled = true;
            this.cb_kichthuoc.ItemHeight = 30;
            this.cb_kichthuoc.Items.AddRange(new object[] {
            "M",
            "L",
            "XL"});
            this.cb_kichthuoc.Location = new System.Drawing.Point(448, 398);
            this.cb_kichthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cb_kichthuoc.Name = "cb_kichthuoc";
            this.cb_kichthuoc.Size = new System.Drawing.Size(163, 36);
            this.cb_kichthuoc.TabIndex = 55;
            // 
            // txt_giaban
            // 
            this.txt_giaban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.txt_giaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giaban.DefaultText = "";
            this.txt_giaban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_giaban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_giaban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giaban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giaban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giaban.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.ForeColor = System.Drawing.Color.Black;
            this.txt_giaban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giaban.Location = new System.Drawing.Point(448, 283);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.PasswordChar = '\0';
            this.txt_giaban.PlaceholderText = "";
            this.txt_giaban.SelectedText = "";
            this.txt_giaban.Size = new System.Drawing.Size(304, 46);
            this.txt_giaban.TabIndex = 54;
            // 
            // txt_tenmathang
            // 
            this.txt_tenmathang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.txt_tenmathang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenmathang.DefaultText = "";
            this.txt_tenmathang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenmathang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenmathang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenmathang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenmathang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenmathang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmathang.ForeColor = System.Drawing.Color.Black;
            this.txt_tenmathang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenmathang.Location = new System.Drawing.Point(448, 169);
            this.txt_tenmathang.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_tenmathang.Name = "txt_tenmathang";
            this.txt_tenmathang.PasswordChar = '\0';
            this.txt_tenmathang.PlaceholderText = "";
            this.txt_tenmathang.SelectedText = "";
            this.txt_tenmathang.Size = new System.Drawing.Size(304, 46);
            this.txt_tenmathang.TabIndex = 52;
            // 
            // btn_TaiAnhLen
            // 
            this.btn_TaiAnhLen.BackColor = System.Drawing.Color.White;
            this.btn_TaiAnhLen.BorderRadius = 10;
            this.btn_TaiAnhLen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_TaiAnhLen.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiAnhLen.ForeColor = System.Drawing.Color.White;
            this.btn_TaiAnhLen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TaiAnhLen.ImageOffset = new System.Drawing.Point(0, 13);
            this.btn_TaiAnhLen.Location = new System.Drawing.Point(858, 497);
            this.btn_TaiAnhLen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaiAnhLen.Name = "btn_TaiAnhLen";
            this.btn_TaiAnhLen.Size = new System.Drawing.Size(339, 60);
            this.btn_TaiAnhLen.TabIndex = 25;
            this.btn_TaiAnhLen.Text = "Tải ảnh lên";
            this.btn_TaiAnhLen.Click += new System.EventHandler(this.btn_TaiAnhLen_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(117, 59);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(190, 38);
            this.guna2HtmlLabel7.TabIndex = 16;
            this.guna2HtmlLabel7.Text = "Loại mặt hàng";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(121, 172);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(184, 38);
            this.guna2HtmlLabel6.TabIndex = 15;
            this.guna2HtmlLabel6.Text = "Tên mặt hàng";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(207, 287);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(107, 38);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Giá bán";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(169, 401);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(144, 38);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = "Kích thước";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(189, 514);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(123, 38);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Số lượng";
            // 
            // pic_AnhMatHang
            // 
            this.pic_AnhMatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_AnhMatHang.ImageRotate = 0F;
            this.pic_AnhMatHang.Location = new System.Drawing.Point(842, 54);
            this.pic_AnhMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.pic_AnhMatHang.Name = "pic_AnhMatHang";
            this.pic_AnhMatHang.Size = new System.Drawing.Size(365, 427);
            this.pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AnhMatHang.TabIndex = 10;
            this.pic_AnhMatHang.TabStop = false;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Image = global::QuanLyCuaHang.Properties.Resources.left_arrow;
            this.btn_quaylai.ImageRotate = 0F;
            this.btn_quaylai.Location = new System.Drawing.Point(5, 10);
            this.btn_quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(53, 49);
            this.btn_quaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quaylai.TabIndex = 30;
            this.btn_quaylai.TabStop = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_XacNhanThem
            // 
            this.btn_XacNhanThem.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_XacNhanThem.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_XacNhanThem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanThem.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhanThem.Image = global::QuanLyCuaHang.Properties.Resources.add_product1;
            this.btn_XacNhanThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_XacNhanThem.ImageOffset = new System.Drawing.Point(0, 18);
            this.btn_XacNhanThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_XacNhanThem.Location = new System.Drawing.Point(1032, -1);
            this.btn_XacNhanThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XacNhanThem.Name = "btn_XacNhanThem";
            this.btn_XacNhanThem.Size = new System.Drawing.Size(261, 70);
            this.btn_XacNhanThem.TabIndex = 26;
            this.btn_XacNhanThem.Text = "Thêm mặt hàng";
            this.btn_XacNhanThem.TextOffset = new System.Drawing.Point(20, -18);
            this.btn_XacNhanThem.Click += new System.EventHandler(this.btn_XacNhanThem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btn_quaylai);
            this.guna2Panel2.Controls.Add(this.btn_XacNhanThem);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 4);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1292, 69);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(448, 16);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(344, 38);
            this.guna2HtmlLabel9.TabIndex = 29;
            this.guna2HtmlLabel9.Text = "Thêm thông tin mặt hàng";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.cb_LoaiMatHang);
            this.guna2Panel1.Controls.Add(this.num_soluong);
            this.guna2Panel1.Controls.Add(this.cb_kichthuoc);
            this.guna2Panel1.Controls.Add(this.txt_giaban);
            this.guna2Panel1.Controls.Add(this.txt_tenmathang);
            this.guna2Panel1.Controls.Add(this.btn_TaiAnhLen);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.pic_AnhMatHang);
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(5, 80);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1292, 598);
            this.guna2Panel1.TabIndex = 5;
            // 
            // uc_ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_ThemSanPham";
            this.Size = new System.Drawing.Size(1301, 682);
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quaylai)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_LoaiMatHang;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_soluong;
        private Guna.UI2.WinForms.Guna2ComboBox cb_kichthuoc;
        private Guna.UI2.WinForms.Guna2TextBox txt_giaban;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenmathang;
        private Guna.UI2.WinForms.Guna2TileButton btn_TaiAnhLen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2PictureBox pic_AnhMatHang;
        private Guna.UI2.WinForms.Guna2PictureBox btn_quaylai;
        private Guna.UI2.WinForms.Guna2TileButton btn_XacNhanThem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
