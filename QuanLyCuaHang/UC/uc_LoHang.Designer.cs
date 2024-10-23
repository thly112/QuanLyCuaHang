namespace QuanLyCuaHang
{
    partial class uc_LoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_huy = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_XacNhanThem = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_ngaynhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_maNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_NhapKho = new Guna.UI2.WinForms.Guna2TileButton();
            this.pnl_ThemLoHang = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_XoaLoHang = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_ThemLoHang = new Guna.UI2.WinForms.Guna2TileButton();
            this.dgv_DetailShipment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Shipment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_ThemLoHang.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailShipment)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.BorderRadius = 10;
            this.btn_huy.FillColor = System.Drawing.Color.DarkGray;
            this.btn_huy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(183, 379);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(153, 53);
            this.btn_huy.TabIndex = 61;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_XacNhanThem
            // 
            this.btn_XacNhanThem.BorderRadius = 10;
            this.btn_XacNhanThem.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_XacNhanThem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanThem.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhanThem.Location = new System.Drawing.Point(15, 379);
            this.btn_XacNhanThem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XacNhanThem.Name = "btn_XacNhanThem";
            this.btn_XacNhanThem.Size = new System.Drawing.Size(153, 53);
            this.btn_XacNhanThem.TabIndex = 60;
            this.btn_XacNhanThem.Text = "Xác nhận";
            this.btn_XacNhanThem.Click += new System.EventHandler(this.btn_XacNhanThem_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 187);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(148, 38);
            this.guna2HtmlLabel3.TabIndex = 59;
            this.guna2HtmlLabel3.Text = "Ngày nhập";
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.Checked = true;
            this.date_ngaynhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.date_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaynhap.ForeColor = System.Drawing.Color.White;
            this.date_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaynhap.Location = new System.Drawing.Point(13, 240);
            this.date_ngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.date_ngaynhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_ngaynhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(321, 48);
            this.date_ngaynhap.TabIndex = 58;
            this.date_ngaynhap.Value = new System.DateTime(2024, 10, 6, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 39);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(232, 38);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Mã nhà cung cấp";
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.txt_maNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maNCC.DefaultText = "";
            this.txt_maNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNCC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNCC.ForeColor = System.Drawing.Color.Black;
            this.txt_maNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNCC.Location = new System.Drawing.Point(13, 90);
            this.txt_maNCC.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.PasswordChar = '\0';
            this.txt_maNCC.PlaceholderText = "";
            this.txt_maNCC.SelectedText = "";
            this.txt_maNCC.Size = new System.Drawing.Size(321, 48);
            this.txt_maNCC.TabIndex = 54;
            // 
            // btn_NhapKho
            // 
            this.btn_NhapKho.BorderRadius = 10;
            this.btn_NhapKho.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_NhapKho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_NhapKho.Location = new System.Drawing.Point(17, 17);
            this.btn_NhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhapKho.Name = "btn_NhapKho";
            this.btn_NhapKho.Size = new System.Drawing.Size(160, 52);
            this.btn_NhapKho.TabIndex = 17;
            this.btn_NhapKho.Text = "Nhập kho";
            this.btn_NhapKho.Click += new System.EventHandler(this.btn_NhapKho_Click);
            // 
            // pnl_ThemLoHang
            // 
            this.pnl_ThemLoHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.pnl_ThemLoHang.Controls.Add(this.btn_huy);
            this.pnl_ThemLoHang.Controls.Add(this.btn_XacNhanThem);
            this.pnl_ThemLoHang.Controls.Add(this.guna2HtmlLabel3);
            this.pnl_ThemLoHang.Controls.Add(this.date_ngaynhap);
            this.pnl_ThemLoHang.Controls.Add(this.guna2HtmlLabel2);
            this.pnl_ThemLoHang.Controls.Add(this.txt_maNCC);
            this.pnl_ThemLoHang.Location = new System.Drawing.Point(4, 172);
            this.pnl_ThemLoHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ThemLoHang.Name = "pnl_ThemLoHang";
            this.pnl_ThemLoHang.Size = new System.Drawing.Size(340, 498);
            this.pnl_ThemLoHang.TabIndex = 16;
            this.pnl_ThemLoHang.Visible = false;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.btn_NhapKho);
            this.guna2Panel5.Controls.Add(this.pnl_ThemLoHang);
            this.guna2Panel5.Controls.Add(this.btn_XoaLoHang);
            this.guna2Panel5.Controls.Add(this.btn_ThemLoHang);
            this.guna2Panel5.Location = new System.Drawing.Point(949, 4);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(348, 674);
            this.guna2Panel5.TabIndex = 12;
            // 
            // btn_XoaLoHang
            // 
            this.btn_XoaLoHang.BorderRadius = 10;
            this.btn_XoaLoHang.FillColor = System.Drawing.Color.DarkGray;
            this.btn_XoaLoHang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLoHang.ForeColor = System.Drawing.Color.White;
            this.btn_XoaLoHang.Location = new System.Drawing.Point(185, 17);
            this.btn_XoaLoHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaLoHang.Name = "btn_XoaLoHang";
            this.btn_XoaLoHang.Size = new System.Drawing.Size(153, 52);
            this.btn_XoaLoHang.TabIndex = 15;
            this.btn_XoaLoHang.Text = "Xóa";
            this.btn_XoaLoHang.Click += new System.EventHandler(this.btn_XoaLoHang_Click);
            // 
            // btn_ThemLoHang
            // 
            this.btn_ThemLoHang.BorderRadius = 10;
            this.btn_ThemLoHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btn_ThemLoHang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLoHang.ForeColor = System.Drawing.Color.White;
            this.btn_ThemLoHang.Location = new System.Drawing.Point(17, 100);
            this.btn_ThemLoHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemLoHang.Name = "btn_ThemLoHang";
            this.btn_ThemLoHang.Size = new System.Drawing.Size(321, 52);
            this.btn_ThemLoHang.TabIndex = 14;
            this.btn_ThemLoHang.Text = "Thêm lô hàng mới";
            this.btn_ThemLoHang.Click += new System.EventHandler(this.btn_ThemLoHang_Click);
            // 
            // dgv_DetailShipment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_DetailShipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetailShipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DetailShipment.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DetailShipment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DetailShipment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailShipment.Location = new System.Drawing.Point(4, 63);
            this.dgv_DetailShipment.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DetailShipment.Name = "dgv_DetailShipment";
            this.dgv_DetailShipment.ReadOnly = true;
            this.dgv_DetailShipment.RowHeadersVisible = false;
            this.dgv_DetailShipment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_DetailShipment.Size = new System.Drawing.Size(933, 258);
            this.dgv_DetailShipment.TabIndex = 5;
            this.dgv_DetailShipment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailShipment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DetailShipment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailShipment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DetailShipment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailShipment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailShipment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DetailShipment.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_DetailShipment.ThemeStyle.ReadOnly = true;
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailShipment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(197, 7);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(505, 38);
            this.guna2HtmlLabel1.TabIndex = 29;
            this.guna2HtmlLabel1.Text = "Danh sách mặt hàng có trong lô hàng";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 2);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(941, 53);
            this.guna2Panel4.TabIndex = 9;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Controls.Add(this.dgv_DetailShipment);
            this.guna2Panel3.Location = new System.Drawing.Point(4, 353);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(941, 325);
            this.guna2Panel3.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.dgv_Shipment);
            this.guna2Panel2.Location = new System.Drawing.Point(4, 4);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(941, 342);
            this.guna2Panel2.TabIndex = 10;
            // 
            // dgv_Shipment
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_Shipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Shipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Shipment.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Shipment.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Shipment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Shipment.Location = new System.Drawing.Point(4, 4);
            this.dgv_Shipment.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Shipment.Name = "dgv_Shipment";
            this.dgv_Shipment.ReadOnly = true;
            this.dgv_Shipment.RowHeadersVisible = false;
            this.dgv_Shipment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_Shipment.Size = new System.Drawing.Size(933, 335);
            this.dgv_Shipment.TabIndex = 5;
            this.dgv_Shipment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Shipment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Shipment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Shipment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Shipment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Shipment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Shipment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Shipment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.dgv_Shipment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Shipment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Shipment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Shipment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Shipment.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Shipment.ThemeStyle.ReadOnly = true;
            this.dgv_Shipment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Shipment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Shipment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Shipment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Shipment.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Shipment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Shipment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Shipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Shipment_CellClick);
            // 
            // uc_LoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_LoHang";
            this.Size = new System.Drawing.Size(1301, 682);
            this.Load += new System.EventHandler(this.us_Shipment_Load);
            this.pnl_ThemLoHang.ResumeLayout(false);
            this.pnl_ThemLoHang.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailShipment)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2TileButton btn_huy;
        private Guna.UI2.WinForms.Guna2TileButton btn_XacNhanThem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_ngaynhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_maNCC;
        private Guna.UI2.WinForms.Guna2TileButton btn_NhapKho;
        private Guna.UI2.WinForms.Guna2Panel pnl_ThemLoHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2TileButton btn_XoaLoHang;
        private Guna.UI2.WinForms.Guna2TileButton btn_ThemLoHang;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DetailShipment;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Shipment;
    }
}
