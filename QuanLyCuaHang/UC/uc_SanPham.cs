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
    public partial class uc_SanPham : UserControl
    {
        public uc_SanPham()
        {
            InitializeComponent();
        }

        public string ItemPrice
        {
            get { return lbl_giaTien.Text; }
            set { lbl_giaTien.Text = value; }
        }

        public Image ItemImage
        {
            get { return ptb_anhSanPham.Image; }
            set { ptb_anhSanPham.Image = value; }
        }

        public string ItemID;

        private void ptb_anhSanPham_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
