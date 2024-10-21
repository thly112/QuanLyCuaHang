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

namespace QuanLyCuaHang
{
    public partial class f_DangNhap : Form
    {
        TaiKhoan dbTaiKhoan;
        public f_DangNhap()
        {
            InitializeComponent();

            panelShop.BackColor = Color.FromArgb(100, Color.White);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Global.Username = txt_Username.Text.Trim();
            Global.Password = txt_Password.Text.Trim();
            dbTaiKhoan = new TaiKhoan();
            bool check = dbTaiKhoan.testLogin(txt_Username.Text.Trim(), txt_Password.Text.Trim());
            if (check)
            {
                DataSet ds = dbTaiKhoan.GetAccount(txt_Username.Text.Trim(), txt_Password.Text.Trim());
                DataTable dt = ds.Tables[0];
                dbTaiKhoan = new TaiKhoan(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                f_TrangChinh frm_home = new f_TrangChinh();
                frm_home.account = dbTaiKhoan;
                this.Hide();
                frm_home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong dung");
            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Text = "";
            }

        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                txt_Username.Text = "Username";
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
            }
            txt_Password.PasswordChar = '*';
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
            }
        }

    }
}
