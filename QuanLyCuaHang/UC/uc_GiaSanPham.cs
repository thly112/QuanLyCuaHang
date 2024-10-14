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
    public partial class uc_GiaSanPham : UserControl
    {
        public string ItemPrice
        {
            get { return lbl_giaTien.Text; }
            set { lbl_giaTien.Text = value; }
        }

        public string ItemID
        {
            get { return lbl_maSP.Text; }
            set { lbl_maSP.Text = value; }
        }

        public string ItemQuantity
        {
            get { return lbl_soLuong.Text; }
            set { lbl_soLuong.Text = value; }
        }

        public uc_GiaSanPham()
        {
            InitializeComponent();
        }

        private void lbl_soLuong_TextChanged(object sender, EventArgs e)
        {
            // Gọi sự kiện tùy chỉnh để thông báo sự thay đổi
            OnContentChanged(EventArgs.Empty);
        }


        public event EventHandler ContentChanged;

        protected virtual void OnContentChanged(EventArgs e)
        {
            ContentChanged?.Invoke(this, e);
        }
    }
}
