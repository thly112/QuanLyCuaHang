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
    public partial class f_DanhSachSanPham : Form
    {
        public f_DanhSachSanPham()
        {
            InitializeComponent();
        }

        private Panel pnl_Main;

        public f_DanhSachSanPham(Panel pnl_Main)
        {
            InitializeComponent();
            this.pnl_Main = pnl_Main;
        }

        private void f_SanPham_Load(object sender, EventArgs e)
        {
            
        }
    }
}
