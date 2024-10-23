using QuanLyCuaHang.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class uc_NhapSanPham : UserControl
    {
        public uc_NhapSanPham()
        {
            InitializeComponent();
        }

        Panel pnl_Main;
        string ma_lo;
        DataTable dtSanPham = new DataTable();
        SanPham dbSanPham = new SanPham();
        //Đổi Product bằng class SanPham m tạo
        LoHang dbLoHang = new LoHang();
        ChiTietLoHang dbChiTietLo = new ChiTietLoHang();
        public uc_NhapSanPham(Panel pnl_Main, string ma_lo)
        {
            InitializeComponent();
            this.pnl_Main = pnl_Main;
            this.ma_lo = ma_lo;
        }

        private void LoadSanPham()
        {
            try
            {
                dtSanPham.Clear();
                DataSet ds = dbSanPham.getProduct();
                dtSanPham = ds.Tables[0];

                if (dtSanPham.Rows.Count > 0)
                {
                    dgv_Product.DataSource = dtSanPham;
                    dgv_Product.Columns[3].Visible = false;
                }
                else
                {
                    MessageBox.Show("Chưa có mặt hàng nào");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Chưa có mặt hàng nào");
            }
        }
        private void LoadLoHang()
        {
            DataRow dr = dbLoHang.getOneShipment(ma_lo);
            txt_malohang.Text = ma_lo;
            txt_maNCC.Text = dr[1].ToString();
            DateTime ngayNhap = (DateTime)dr[2];
            txt_NgayNhap.Text = ngayNhap.ToString("dd/MM/yyyy");
        }
        private void ThemChiTietLoHang()
        {
            try
            {
                dbChiTietLo.addDetailShipment(txt_malohang.Text.Trim(), txt_mamathang.Text.Trim(),
                    (decimal)Convert.ToDouble(txt_gianhap.Text.Trim()), (int)Convert.ToInt64(num_soluongmathang.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Đổi lại hàm gọi 
        private void LamMoi()
        {
            txt_mamathang.Text = "";
            txt_gianhap.Text = "";
            num_soluongmathang.Value = 0;
        }

        private void LamMoiTimKiem()
        {
            txt_timten.Text = "";
            cb_LoaiMatHang.SelectedIndex = 0;
            LoadSanPham();
        }
        //private void TimMatHang()
        //{
        //    dtSanPham = new DataTable();
        //    dtSanPham.Clear();
        //    dtSanPham = dbSanPham.findProductByName(txt_timten.Text).Tables[0];
        //    dgv_Product.DataSource = dtSanPham;

        //    dgv_Product.Columns[3].Visible = false;
        //}
        //private void TimMatHangTheoLoai(string loai)
        //{
        //    dtSanPham = new DataTable();
        //    dtSanPham.Clear();
        //    dtSanPham = dbSanPham.findProductById(loai).Tables[0];
        //    dgv_Product.DataSource = dtSanPham;

        //    dgv_Product.Columns[3].Visible = false;
        //}
        
        private void uc_NhapSanPham_Load(object sender, EventArgs e)
        {
            LoadLoHang();
            LoadSanPham();
            cb_LoaiMatHang.SelectedIndex = 0;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            uc_LoHang uc_LoHang = new uc_LoHang(pnl_Main);
            TienIch.addUserControl(uc_LoHang, pnl_Main);
        }

        private void btn_XacNhanThem_Click(object sender, EventArgs e)
        {
            ThemChiTietLoHang();
            LoadSanPham();
            LamMoi();
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma_sanPham;
            int i;
            i = dgv_Product.CurrentRow.Index;
            ma_sanPham = dgv_Product.Rows[i].Cells[0].Value.ToString();

            txt_mamathang.Text = ma_sanPham;

            pic_AnhMatHang.Image = TienIch.ConvertByteArraytoImage((byte[])dgv_Product.Rows[i].Cells[3].Value);
            pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void pic_TimMatHang_Click(object sender, EventArgs e)
        {
            dtSanPham = new DataTable();
            dtSanPham.Clear();
            dtSanPham = dbSanPham.findProductByName(txt_timten.Text).Tables[0];
            dgv_Product.DataSource = dtSanPham;

            dgv_Product.Columns[3].Visible = false;
        }

        string loai;
        private void cb_LoaiMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_LoaiMatHang.SelectedItem != null)
            {
                if (cb_LoaiMatHang.SelectedIndex == 0) loai = "";
                if (cb_LoaiMatHang.SelectedIndex == 1) loai = "PT";
                if (cb_LoaiMatHang.SelectedIndex == 2) loai = "PK";
                if (cb_LoaiMatHang.SelectedIndex == 3) loai = "PM";
                if (cb_LoaiMatHang.SelectedIndex == 4) loai = "PP";
                if (cb_LoaiMatHang.SelectedIndex == 5) loai = "PJ";
                if (cb_LoaiMatHang.SelectedIndex == 6) loai = "PE";
                if (cb_LoaiMatHang.SelectedIndex == 7) loai = "PS";
            }
            dtSanPham = new DataTable();
            dtSanPham.Clear();
            dtSanPham = dbSanPham.findProductById(loai).Tables[0];
            dgv_Product.DataSource = dtSanPham;

            dgv_Product.Columns[3].Visible = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoiTimKiem();
        }
    }
}
