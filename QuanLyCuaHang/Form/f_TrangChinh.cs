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
    public partial class f_TrangChinh : Form
    {
        public f_TrangChinh()
        {
            InitializeComponent();
        }

        private void f_Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //lbl_Name.Text = account.name.ToString();
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
    }
}
