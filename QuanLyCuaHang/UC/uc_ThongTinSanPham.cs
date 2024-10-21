using QuanLyCuaHang.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class uc_ThongTinSanPham : UserControl
    {
        public uc_ThongTinSanPham()
        {
            InitializeComponent();
        }

        private Panel pnl_Main;
        string ma_SanPham;
        public uc_ThongTinSanPham(Panel pnl_Main, string ma_SanPham)
        {
            InitializeComponent();
            this.pnl_Main = pnl_Main;
            this.ma_SanPham = ma_SanPham;
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            f_DanhSachSanPham frm_MatHang = new f_DanhSachSanPham(pnl_Main);
            TienIch.addForm(frm_MatHang, pnl_Main);
        }

        private void uc_ThongTinSanPham_Load(object sender, EventArgs e)
        {
            LoadThongTinSanPham();
        }

        DataTable dtSanPham = new DataTable();
        SanPham dbSanPham = new SanPham();
        //Đổi Product thành class SanPham m tạo
        byte[] img = null;
        public void LoadThongTinSanPham()
        {
            try
            {
                DataRow dr = dbSanPham.getOneProduct(ma_SanPham);
                txt_mamathang.Text = dr[0].ToString();
                txt_tenmathang.Text = dr[1].ToString();
                txt_giaban.Text = dr[2].ToString();
                cb_kichthuoc.Text = dr[4].ToString();
                num_soluong.Value = int.Parse(dr[5].ToString());
                txt_LoaiMatHang.Text = dbSanPham.GetTypeProduct(ma_SanPham);
                img = (byte[])dr[3];
                pic_AnhMatHang.Image = TienIch.ConvertByteArraytoImage(img);
                pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            }
            catch (SqlException)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btn_ThayDoiAnh_Click(object sender, EventArgs e)
        {
            ThayDoiAnh();
        }

        string imgLoc = "";
        private void ThayDoiAnh()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                //Danh sách đuôi hình có thể upload
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.* |PNG Files (*.png)|*.png";
                dlg.Title = "Select Product Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_AnhMatHang.ImageLocation = imgLoc; //Chọn đường dẫn file hình để upload
                    pic_AnhMatHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                img = new byte[fs.Length];
                fs.Read(img, 0, Convert.ToInt32(fs.Length));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LuuThayDoi_Click(object sender, EventArgs e)
        {
            CapNhatMathang();
        }
        private void CapNhatMathang()
        {
            try
            {
                dbSanPham.updateProduct(txt_mamathang.Text.Trim(), txt_tenmathang.Text.Trim(), (decimal)Convert.ToDouble(txt_giaban.Text.Trim()),
                    img, cb_kichthuoc.Text.Trim(), (int)Convert.ToInt64(num_soluong.Text.Trim()));
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
