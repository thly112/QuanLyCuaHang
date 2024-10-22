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
    public partial class f_DanhSachSanPham : Form
    {
        public f_DanhSachSanPham()
        {
            InitializeComponent();
        }

        private Panel pnl_trangchinh;

        public f_DanhSachSanPham(Panel pnl_trangchinh)
        {
            InitializeComponent();
            this.pnl_trangchinh = pnl_trangchinh;
        }

        DataTable dtProduct = new DataTable();
        SanPham dbProduct = new SanPham();
        string id_product;

        private void f_SanPham_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        public void LoadProduct()
        {
            try
            {
                dtProduct.Clear();
                DataSet ds = dbProduct.getProduct();
                dtProduct = ds.Tables[0];

                if (dtProduct.Rows.Count > 0)
                {
                    dgv_Product.DataSource = dtProduct;
                    dgv_Product.Columns[3].Visible = false;

                    id_product = dgv_Product.Rows[0].Cells[0].Value.ToString();

                    //pic_AnhMatHang.Image = TienIch.ConvertByteArraytoImage((byte[])dgv_Product.Rows[0].Cells[3].Value);
                    //pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }
        private void XemChiTiet()
        {
            try
            {
                uc_ThongTinSanPham uc_ThongTinSanPham = new uc_ThongTinSanPham(pnl_trangchinh, id_product);
                TienIch.addUserControl(uc_ThongTinSanPham, pnl_trangchinh);
            }
            catch
            {
                f_DanhSachSanPham Fmathang = new f_DanhSachSanPham(this.pnl_trangchinh);
                TienIch.addForm(Fmathang, pnl_trangchinh);
                MessageBox.Show("Chưa thêm đủ thông tin về Nhà sản xuất hoặc Lô hàng", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            uc_ThemSanPham uc_ThemSanPham = new uc_ThemSanPham(pnl_trangchinh);
            TienIch.addUserControl(uc_ThemSanPham, pnl_trangchinh);
        }
        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = dgv_Product.CurrentRow.Index;
            //id_product = dgv_Product.Rows[i].Cells[0].Value.ToString();

            //pic_AnhMatHang.Image = TienIch.ConvertByteArraytoImage((byte[])dgv_Product.Rows[i].Cells[3].Value);
            //pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            try
            {
                // Kiểm tra chỉ mục hàng để tránh lỗi khi nhấn vào tiêu đề cột
                // Lấy hàng hiện tại
                    int i;
                    i = dgv_Product.CurrentRow.Index;
                // Lấy mã sản phẩm từ cột đầu tiên
                    id_product = dgv_Product.Rows[i].Cells[0].Value.ToString();

                    // Kiểm tra xem cột ảnh có dữ liệu hay không
                    if (dgv_Product.Rows[i].Cells[3].Value != DBNull.Value && dgv_Product.Rows[i].Cells[3].Value is byte[])
                    {
                        // Chuyển byte array thành Image và hiển thị trên PictureBox
                        byte[] imageData = (byte[])dgv_Product.Rows[i].Cells[3].Value;
                        pic_AnhMatHang.Image = TienIch.ConvertByteArraytoImage(imageData);
                        pic_AnhMatHang.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        // Nếu không có ảnh, xóa ảnh trên PictureBox
                        pic_AnhMatHang.Image = null;
                        MessageBox.Show("Có lỗi khi hiển thị ảnh: ");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi hiển thị ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaMatHang();
        }
        private void XoaMatHang()
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa sản phẩm?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbProduct.deleteProduct(id_product);
                    // Cập nhật lại DataGridView 
                    LoadProduct();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");

                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void pic_timkiem_Click(object sender, EventArgs e)
        {
            TimMatHang();
        }
        private void TimMatHang()
        {
            dtProduct = new DataTable();
            dtProduct.Clear();
            dtProduct = dbProduct.findProductByName(txt_timten.Text).Tables[0];
            dgv_Product.DataSource = dtProduct;

            dgv_Product.Columns[3].Visible = false;
        }

        private void btn_AoThun_Click(object sender, EventArgs e)
        {
            string idtype = "PT";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_AoKhoac_Click(object sender, EventArgs e)
        {
            string idtype = "PK";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_AoSoMi_Click(object sender, EventArgs e)
        {
            string idtype = "PM";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_AoPolo_Click(object sender, EventArgs e)
        {
            string idtype = "PP";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_QuanJean_Click(object sender, EventArgs e)
        {
            string idtype = "PJ";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_QuanTay_Click(object sender, EventArgs e)
        {
            string idtype = "PE";
            TimMatHangTheoLoai(idtype);
        }

        private void btn_QuanShort_Click(object sender, EventArgs e)
        {
            string idtype = "PS";
            TimMatHangTheoLoai(idtype);
        }

        private void TimMatHangTheoLoai(string idtype)
        {
            dtProduct = new DataTable();
            dtProduct.Clear();
            dtProduct = dbProduct.findProductById(idtype).Tables[0];
            dgv_Product.DataSource = dtProduct;

            dgv_Product.Columns[3].Visible = false;
        }
    }
}
