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
using System.Xml.Linq;

namespace QuanLyCuaHang
{
    public partial class uc_BanHang : UserControl
    {
        public uc_BanHang()
        {
            InitializeComponent();
        }
        SanPham product = new SanPham();
        HoaDon bill = new HoaDon();
        ChiTietHoaDon detail_Bill = new ChiTietHoaDon();
        KhachHang customer = new KhachHang();
        public string eid;
        private bool hasChanges = false;

        private void uc_BanHang_Load(object sender, EventArgs e)
        {
            Panel_Product.Controls.Clear();
            product.getProductList(Panel_Product, Panel_ProductPay);

            Panel_ProductPay.ControlAdded += Panel_ProductPay_ControlAdded;
        }
        private void Panel_ProductPay_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is uc_GiaSanPham usProductPay)
            {
                usProductPay.ContentChanged += ItemContentChanged;
            }
            loadTotalMoney();
        }

        void loadTotalMoney()
        {
            Decimal total = 0;
            foreach (UserControl userControl in Panel_ProductPay.Controls)
            {
                // Kiểm tra nếu UserControl là kiểu của UserControl bạn đã tạo
                if (userControl is uc_GiaSanPham)
                {
                    uc_GiaSanPham yourUserControl = (uc_GiaSanPham)userControl;
                    total += Decimal.Parse(yourUserControl.ItemPrice.ToString()) * Decimal.Parse(yourUserControl.ItemQuantity.ToString());
                }

            }
            txt_TotalMoney.Text = total.ToString();
        }
        private void ItemContentChanged(object sender, EventArgs e)
        {
            // Đánh dấu rằng có sự thay đổi
            hasChanges = true;

            // Thực hiện hành động khi có sự thay đổi
            loadTotalMoney();
        }

        private void txt_TotalMoney_TextChanged(object sender, EventArgs e)
        {
            txt_ThanhTien.Text = (Decimal.Parse(txt_TotalMoney.Text) - Decimal.Parse(txt_KhuyenMai.Text)).ToString();
            LoadTotalPay();
        }
        public void LoadTotalPay()
        {
            Decimal total;
            if (Decimal.Parse(txt_ThanhTien.Text) - Decimal.Parse(txt_Point.Text) > 0)
            {
                total = Decimal.Parse(txt_ThanhTien.Text) - Decimal.Parse(txt_Point.Text);
            }
            else
            {
                total = 0;
            }
            txt_ThanhTien.Text = total.ToString();
        }

        private void txt_KhuyenMai_TextChanged(object sender, EventArgs e)
        {
            Decimal sale;
            if (txt_KhuyenMai.Text.Length == 0)
            {
                sale = 0;
            }
            else
            {
                sale = Decimal.Parse(txt_KhuyenMai.Text);
            }
            txt_ThanhTien.Text = (Decimal.Parse(txt_TotalMoney.Text) - sale).ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DataSet ds = customer.findCustomerByPhone(txt_SoDienThoai.Text.Trim());
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                customer.addCustomer(txt_SoDienThoai.Text.Trim(), txt_TenKhachHang.Text.Trim(), 0);
            }
            string b_id = bill.createAutoID();
            try
            {
                if (txt_ThanhTien.Text == "")
                {
                    txt_ThanhTien.Text = "0";
                }
                if (txt_KhuyenMai.Text == "")
                {
                    txt_KhuyenMai.Text = "0";
                }
                bill.addBill(b_id.Trim(), Convert.ToDateTime(DateTime.Now), (decimal)Convert.ToDouble(txt_TotalMoney.Text.Trim()),
                    (decimal)Convert.ToDouble(txt_KhuyenMai.Text.Trim()), txt_SoDienThoai.Text.Trim(), eid.Trim());
                foreach (UserControl userControl in Panel_ProductPay.Controls)
                {
                    // Kiểm tra nếu UserControl là kiểu của UserControl bạn đã tạo
                    if (userControl is uc_GiaSanPham)
                    {
                        uc_GiaSanPham yourUserControl = (uc_GiaSanPham)userControl;
                        detail_Bill.addDetailBill(b_id.Trim(), yourUserControl.ItemID.ToString().Trim(),
                            (int)Convert.ToInt64(yourUserControl.ItemQuantity.ToString().Trim()));
                    }

                }
                MessageBox.Show("Them bill thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Point_TextChanged(object sender, EventArgs e)
        {
            LoadTotalPay();
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            //LoadPoint();
            DataSet ds = customer.findCustomerByPhone(txt_SoDienThoai.Text.Trim());
            DataTable dt = ds.Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                txt_TenKhachHang.Text = dt.Rows[0][1].ToString();
                txt_Point.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                txt_TenKhachHang.Text = "";
                txt_Point.Text = "0";
            }
        }

        //public void LoadPoint()
        //{
        //    DataSet ds = customer.timKhachHangTheoSDT(txt_SoDienThoai.Text.Trim());
        //    DataTable dt = ds.Tables[0];
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        txt_TenKhachHang.Text = dt.Rows[0][1].ToString();
        //        txt_Point.Text = dt.Rows[0][2].ToString();
        //    }
        //    else
        //    {
        //        txt_TenKhachHang.Text = "";
        //        txt_Point.Text = "0";
        //    }
        //}

        private void btn_ApDung_Click(object sender, EventArgs e)
        {
            //string loai = cb_loai.SelectedItem?.ToString();
            //string kichco = cb_kichco.SelectedItem?.ToString();

            //// Xóa danh sách sản phẩm hiện có trên Panel_Product
            //Panel_Product.Controls.Clear();

            //// Nếu cả hai bộ lọc (loại và kích cỡ) đều rỗng, tải lại toàn bộ sản phẩm
            //if (string.IsNullOrEmpty(loai) && string.IsNullOrEmpty(kichco))
            //{
            //    product.getProductList(Panel_Product, Panel_ProductPay);
            //}
            //else
            //{
            //    // Gọi hàm lọc sản phẩm dựa theo giá trị đã chọn
            //    product.findFilteredProductList(Panel_Product, Panel_ProductPay, loai, kichco);
            //}

            //// Thêm lại sự kiện sau khi panel sản phẩm được làm mới
            Panel_ProductPay.ControlAdded += Panel_ProductPay_ControlAdded;
        }

        private void pb_TimKiem_Click(object sender, EventArgs e)
        {
            Panel_Product.Controls.Clear();
            product.findProductList(Panel_Product, Panel_ProductPay, txt_TenMatHang.Text.Trim());
            Panel_ProductPay.ControlAdded += Panel_ProductPay_ControlAdded;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Panel_Product.Controls.Clear();
            product.getProductList(Panel_Product, Panel_ProductPay);

            Panel_ProductPay.ControlAdded += Panel_ProductPay_ControlAdded;
        }

    }
}
