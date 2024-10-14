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
    public partial class uc_NhapSanPham : UserControl
    {
        public uc_NhapSanPham()
        {
            InitializeComponent();
        }

        Panel pnl_Main;
        string ma_lo;

        public uc_NhapSanPham(Panel pnl_Main, string ma_lo)
        {
            InitializeComponent();
            this.pnl_Main = pnl_Main;
            this.ma_lo = ma_lo;
        }

    }
}
