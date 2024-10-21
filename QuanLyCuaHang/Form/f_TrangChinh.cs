using QuanLyCuaHang.DS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace QuanLyCuaHang
{
    public partial class f_TrangChinh : Form
    {
        Color background1 = Color.FromArgb(65, 100, 74);
        public TaiKhoan account;
        public f_TrangChinh()
        {
            InitializeComponent();
        }

        private void f_TrangChinh_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_Name.Text = account.name.ToString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pic_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            uc_TaiKhoan account = new uc_TaiKhoan();
            TienIch.addUserControl(account, pnl_trangchinh);
            LayLaiMau();
            btn_Account.FillColor = Color.FromArgb(120, 159, 196);
        }
        private void LayLaiMau()
        {
            btn_Banhang.FillColor = Color.FromArgb(75, 115, 165);
            btn_HienThiMatHang.FillColor = Color.FromArgb(75, 115, 165);
            btn_LoHang.FillColor = Color.FromArgb(75, 115, 165);
            btn_HienThiHoaDon.FillColor = Color.FromArgb(75, 115, 165);
            btn_NhaCungCap.FillColor = Color.FromArgb(75, 115, 165);
            btn_HienThiKhachHang.FillColor = Color.FromArgb(75, 115, 165);
            btn_thongke.FillColor = Color.FromArgb(75, 115, 165);
            btn_QuanlyNhanvien.FillColor = Color.FromArgb(75, 115, 165);
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void btn_Banhang_Click(object sender, EventArgs e)
        {
            uc_BanHang uc_Banhang = new uc_BanHang();
            uc_Banhang.eid = account.eid.ToString();
            TienIch.addUserControl(uc_Banhang, pnl_trangchinh);
            LayLaiMau();
            btn_Banhang.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_HienThiMatHang_Click(object sender, EventArgs e)
        {
            f_DanhSachSanPham Fmathang = new f_DanhSachSanPham(pnl_trangchinh);
            TienIch.addForm(Fmathang, pnl_trangchinh);
            LayLaiMau();
            btn_HienThiMatHang.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_LoHang_Click(object sender, EventArgs e)
        {
            uc_LoHang us_Shipment = new uc_LoHang(pnl_trangchinh);
            TienIch.addUserControl(us_Shipment, pnl_trangchinh);
            LayLaiMau();
            btn_LoHang.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_HienThiHoaDon_Click(object sender, EventArgs e)
        {
            uc_DanhSachHoaDon paymentUI = new uc_DanhSachHoaDon(pnl_trangchinh);
            TienIch.addUserControl(paymentUI, pnl_trangchinh);
            LayLaiMau();
            btn_HienThiHoaDon.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            uc_NhaCungCap supplier = new uc_NhaCungCap();
            TienIch.addUserControl(supplier, pnl_trangchinh);
            LayLaiMau();
            btn_NhaCungCap.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_HienThiKhachHang_Click(object sender, EventArgs e)
        {
            uc_KhachHang customerUI = new uc_KhachHang();
            TienIch.addUserControl(customerUI, pnl_trangchinh);
            LayLaiMau();
            btn_HienThiHoaDon.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            uc_ThongKe statistic = new uc_ThongKe();
            TienIch.addUserControl(statistic, pnl_trangchinh);
            LayLaiMau();
            btn_thongke.FillColor = Color.FromArgb(120, 159, 196);
        }

        private void btn_QuanlyNhanvien_Click(object sender, EventArgs e)
        {
            uc_NhanVien employeeUI = new uc_NhanVien();
            TienIch.addUserControl(employeeUI, pnl_trangchinh);
            LayLaiMau();
            btn_QuanlyNhanvien.FillColor = Color.FromArgb(120, 159, 196);
        }
    }
}
