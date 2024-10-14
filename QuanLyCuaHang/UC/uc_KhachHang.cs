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
    public partial class uc_KhachHang : UserControl
    {
        public uc_KhachHang()
        {
            InitializeComponent();
        }

        private void uc_KhachHang_Load(object sender, EventArgs e)
        {

        }

        bool addFlag;

        void trangThai_khongNhap()
        {
            txt_SoDienThoai.Enabled = false;
            txt_TenKhachHang.Enabled = false;
            txt_DiemTichLuy.Enabled = false;
            rb_HD.Enabled = false;
            rb_KhongHD.Enabled = false;
        }
       
        void trangThai_Nhap()
        {
            txt_SoDienThoai.Enabled = true;
            txt_TenKhachHang.Enabled = true;
            txt_DiemTichLuy.Enabled = true;
            rb_HD.Enabled = true;
            rb_KhongHD.Enabled = true;
        }
       
        void trangThai_banDau()
        {
            trangThai_khongNhap();
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        
        private void lamMoi()
        {
            txt_SoDienThoai.Text = "";
            txt_TenKhachHang.Text = "";
            txt_DiemTichLuy.Text = "";
            rb_HD.Checked = false;
            rb_KhongHD.Checked = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            dgv_DanhSachKHD.Visible = true;
            dgv_DanhSachHD.Visible = true;
            dgv_TimKiem.Visible = false;
            lbl_HD.Visible = true;
            lbl_TimKiem.Visible = false;
            txt_TimTheoSDT.Text = "Theo số điện thoại";
            txt_TimTheoTen.Text = "Theo tên khách hàng";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            addFlag = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            addFlag = true;
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Sua.Enabled = false;

            //Mở các ô cho phép điền thông tin\
            trangThai_Nhap();
            lamMoi();
            rb_HD.Enabled = false;
            rb_KhongHD.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Trường hợp khi người dùng chưa chọn Khách hàng cần sửa thông tin
            if (txt_SoDienThoai.Text == "" || txt_SoDienThoai.Text == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần chỉnh sửa thông tin", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Sua.Enabled = true;

            //Mở các ô cho phép điền thông tin\
            trangThai_Nhap();
            txt_SoDienThoai.Enabled = false;
        }

        private void txt_TimTheoSDT_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoSDT.Text == "Theo số điện thoại")
            {
                txt_TimTheoSDT.Text = "";
            }
        }

        private void txt_TimTheoSDT_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoSDT.Text == "")
            {
                txt_TimTheoSDT.Text = "Theo số điện thoại";
            }
        }

        private void txt_TimTheoTen_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "Theo tên khách hàng")
            {
                txt_TimTheoTen.Text = "";
            }
        }

        private void txt_TimTheoTen_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "")
            {
                txt_TimTheoTen.Text = "Theo tên khách hàng";
            }
        }
    }
}
