using QuanLyCuaHang.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class uc_ThongKe : UserControl
    {
        public uc_ThongKe()
        {
            InitializeComponent();
        }
        LoHang dbLoHang = new LoHang();
        HoaDon dbHoaDon = new HoaDon();
        KhachHang dbKhachHang = new KhachHang();
        SanPham dbSanPham = new SanPham();
        DataTable dtSanPham = new DataTable();

        Decimal tongTienNhapHang;
        Decimal tongTienBanHang;
        Decimal tongDoanhThu;
        Decimal tongTien;

        private void uc_ThongKe_Load(object sender, EventArgs e)
        {
            tongTienNhapHang = dbLoHang.totalImportFee(0);
            tongTienBanHang = dbHoaDon.totalSellFee(0);
            tongDoanhThu = tongTienBanHang - tongTienNhapHang;
            tongTien = tongDoanhThu;
            HienThiThongTin();
            loadSLKhachHang();
            lbl_SPDaBan.Text = dbHoaDon.totalProductSell(0).ToString();
            LoadSanPhamBanChay(1);
        }
        private void chart(decimal _tongTienNhapHang, decimal _tongTienBanHang)
        {
            // Set up the chart properties
            chart1.ChartAreas[0].AxisY.Title = "Tổng tiền";
            chart1.Series.Clear();
            chart1.Series.Add("Tổng tiền nhập hàng");
            chart1.Series.Add("Tổng tiền bán hàng");

            // Add data points to the chart
            chart1.Series["Tổng tiền nhập hàng"].Points.AddXY("", _tongTienNhapHang);
            chart1.Series["Tổng tiền bán hàng"].Points.AddXY("", _tongTienBanHang);

            // Hide X-axis labels
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            // Hide X-axis ticks
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;

            // Optionally, you can hide X-axis lines
            chart1.ChartAreas[0].AxisX.LineWidth = 0;
        }

        private void loadSLKhachHang()
        {
            int result = dbKhachHang.customerNumber();
            lbl_tongKhachHang.Text = result.ToString();
        }
        //Đổi hàm gọi
        private void HienThiThongTin()
        {
            lbl_tongtien.Text = tongTien.ToString();
        }

        private void cb_SoNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SoNgay.SelectedItem != null)
            {
                if (cb_SoNgay.SelectedIndex == 0)
                {
                    tongTienNhapHang = dbLoHang.totalImportFee(1000);
                    tongTienBanHang = dbHoaDon.totalSellFee(1000);
                    chart(tongTienNhapHang, tongTienBanHang);
                    lbl_SPDaBan.Text = dbHoaDon.totalProductSell(1000).ToString();
                    LoadSanPhamBanChay(1001);
                }
                if (cb_SoNgay.SelectedIndex == 1)
                {
                    tongTienNhapHang = dbLoHang.totalImportFee(0);
                    tongTienBanHang = dbHoaDon.totalSellFee(0);
                    chart(tongTienNhapHang, tongTienBanHang);
                    lbl_SPDaBan.Text = dbHoaDon.totalProductSell(0).ToString();
                    LoadSanPhamBanChay(1);
                }
                if (cb_SoNgay.SelectedIndex == 2)
                {
                    tongTienNhapHang = dbLoHang.totalImportFee(7);
                    tongTienBanHang = dbHoaDon.totalSellFee(7);
                    chart(tongTienNhapHang, tongTienBanHang);
                    lbl_SPDaBan.Text = dbHoaDon.totalProductSell(7).ToString();
                    LoadSanPhamBanChay(8);
                }
                if (cb_SoNgay.SelectedIndex == 3)
                {
                    tongTienNhapHang = dbLoHang.totalImportFee(30);
                    tongTienBanHang = dbHoaDon.totalSellFee(30);
                    chart(tongTienNhapHang, tongTienBanHang);
                    lbl_SPDaBan.Text = dbHoaDon.totalProductSell(30).ToString();
                    LoadSanPhamBanChay(31);
                }
                if (cb_SoNgay.SelectedIndex == 4)
                {
                    tongTienNhapHang = dbLoHang.totalImportFee(90);
                    tongTienBanHang = dbHoaDon.totalSellFee(90);
                    chart(tongTienNhapHang, tongTienBanHang);
                    lbl_SPDaBan.Text = dbHoaDon.totalProductSell(90).ToString();
                    LoadSanPhamBanChay(91);
                }

                tongDoanhThu = tongTienBanHang - tongTienNhapHang;

                if (cb_Tong.SelectedIndex == 0)
                {
                    tongTien = tongDoanhThu;
                }
                if (cb_Tong.SelectedIndex == 1)
                {
                    tongTien = tongTienNhapHang;
                }
                if (cb_Tong.SelectedIndex == 2)
                {
                    tongTien = tongTienBanHang;
                }

                HienThiThongTin();
            }
        }

        private void cb_Tong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Tong.SelectedItem != null)
            {
                if (cb_Tong.SelectedIndex == 0)
                {
                    tongTien = tongDoanhThu;
                }
                if (cb_Tong.SelectedIndex == 1)
                {
                    tongTien = tongTienNhapHang;
                }
                if (cb_Tong.SelectedIndex == 2)
                {
                    tongTien = tongTienBanHang;
                }
                HienThiThongTin();
            }
        }
        public void LoadSanPhamBanChay(int date)
        {
            dtSanPham.Clear();
            DataSet ds = dbSanPham.getProductBestSeller(date);
            dtSanPham = ds.Tables[0];
            dgv_ListProductBestSeller.DataSource = dtSanPham;
            setDataGridView();
        }
        //Đổi hàm gọi
        private void setDataGridView()
        {
            if (dgv_ListProductBestSeller != null)
            {
                //Set Header Text cho dtgv
                dgv_ListProductBestSeller.Columns[0].HeaderText = "ID";
                dgv_ListProductBestSeller.Columns[1].HeaderText = "Tên sản phẩm";
                dgv_ListProductBestSeller.Columns[2].HeaderText = "Kích thước";
                dgv_ListProductBestSeller.Columns[3].HeaderText = "Số lượng";

                //Set chiều rộng cột
                int width = dgv_ListProductBestSeller.Width;
                int n_column = dgv_ListProductBestSeller.ColumnCount;
                dgv_ListProductBestSeller.Columns[0].Width -= width / n_column;
                dgv_ListProductBestSeller.Columns[1].Width -= width / n_column;
                dgv_ListProductBestSeller.Columns[2].Width -= width / n_column;
                dgv_ListProductBestSeller.Columns[3].Width -= width / n_column;
                dgv_ListProductBestSeller.AutoResizeColumns();

                // Set độ cao của Header Text
                dgv_ListProductBestSeller.ColumnHeadersHeight = 40; // Điều chỉnh độ cao tùy ý
            }
        }
    }
}
