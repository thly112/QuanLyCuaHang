using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class uc_TaiKhoan : UserControl
    {
        public uc_TaiKhoan()
        {
            InitializeComponent();
        }

        bool addFlag;
        int role = 0;

        void trangThai_khongNhap()
        {
            txt_TaiKhoan.Enabled = false;
            txt_MaNhanVien.Enabled = false;
            txt_MatKhau.Enabled = false;
            rbtn_Quanly.Enabled = false;
            rb_HD.Enabled = false;
            rb_KhongHD.Enabled = false;
        }
        
        void trangThai_Nhap()
        {
            txt_TaiKhoan.Enabled = true;
            txt_MaNhanVien.Enabled = true;
            txt_MatKhau.Enabled = true;
            rbtn_Quanly.Enabled = true;
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
        }
        
        private void lamMoi()
        {
            txt_TaiKhoan.Text = "";
            txt_MaNhanVien.Text = "";
            txt_MatKhau.Text = "";
            rbtn_Quanly.Checked = false;
            rb_HD.Checked = false;
            rb_KhongHD.Checked = false;
        }
       
        private void rbtn_Quanly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Quanly.Checked)
            {
                role = 1;
            }
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
        }
     
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Trường hợp khi người dùng chưa chọn nhan vien cần sửa thông tin
            if (txt_MaNhanVien.Text == "" || txt_MaNhanVien.Text == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần chỉnh sửa thông tin", "Lỗi",
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
            txt_MaNhanVien.Enabled = false;
            txt_TaiKhoan.Enabled = false;
        }
      
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            addFlag = false;
        }
       
        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            //LoadAccount();
            txt_TimTheoTenTK.Text = "Theo tên đăng nhập";
            txt_TimTheoID.Text = "Theo mã nhân viên";
        }
        private void txt_TimTheoTenTK_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoTenTK.Text == "Theo tên đăng nhập")
            {
                txt_TimTheoTenTK.Text = "";
            }
        }

        private void txt_TimTheoTenTK_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoTenTK.Text == "")
            {
                txt_TimTheoTenTK.Text = "Theo tên đăng nhập";
            }
        }
       
        private void txt_TimTheoID_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoID.Text == "Theo mã nhân viên")
            {
                txt_TimTheoID.Text = "";
            }
        }

        private void txt_TimTheoID_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoID.Text == "")
            {
                txt_TimTheoID.Text = "Theo mã nhân viên";
            }
        }

        private void pb_TimTheoTenTK_Click(object sender, EventArgs e)
        {

        }

        private void pb_TimTheoID_Click(object sender, EventArgs e)
        {

        }
    }
}
