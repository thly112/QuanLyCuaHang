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
    public partial class uc_NhanVien : UserControl
    {
        public uc_NhanVien()
        {
            InitializeComponent();
        }

        bool addFlag;

        void trangThai_khongNhap()
        {
            txt_SoDienThoai.Enabled = false;
            txt_MaNhanVien.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            txt_DiaChi.Enabled = false;
            rb_Nam.Enabled = false;
            rb_Nu.Enabled = false;
        }

        void trangThai_Nhap()
        {
            txt_SoDienThoai.Enabled = true;
            txt_MaNhanVien.Enabled = true;
            txt_TenNhanVien.Enabled = true;
            txt_DiaChi.Enabled = true;
            rb_Nam.Enabled = true;
            rb_Nu.Enabled = true;
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
            txt_MaNhanVien.Text = "";
            txt_TenNhanVien.Text = "";
            txt_DiaChi.Text = "";
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
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
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Trường hợp khi người dùng chưa chọn nhan vien cần sửa thông tin
            if (txt_MaNhanVien.Text == "" || txt_MaNhanVien.Text == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa thông tin", "Lỗi",
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
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_Nhap();
            //LoadEmployee();
            txt_TimTheoMaNV.Text = "Theo mã nhân viên";
            txt_TimTheoTen.Text = "Theo tên nhân viên";
        }

        private void txt_TimTheoMaNV_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoMaNV.Text == "Theo mã nhân viên")
            {
                txt_TimTheoMaNV.Text = "";
            }
        }

        private void txt_TimTheoMaNV_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoMaNV.Text == "")
            {
                txt_TimTheoMaNV.Text = "Theo mã nhân viên";
            }
        }

        private void txt_TimTheoTen_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "Theo tên nhân viên")
            {
                txt_TimTheoTen.Text = "";
            }
        }

        private void txt_TimTheoTen_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "")
            {
                txt_TimTheoTen.Text = "Theo tên nhân viên";
            }
        }
    }
}
