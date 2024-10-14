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
                
        public f_DangNhap()
        {
            InitializeComponent();

            panelShop.BackColor = Color.FromArgb(100, Color.White);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

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
