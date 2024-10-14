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
            //TienIch.addForm(frm_MatHang, pnl_Main);
        }


    }
}
