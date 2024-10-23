using QuanLyCuaHang.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class f_HoaDon : Form
    {
        public f_HoaDon()
        {
            InitializeComponent();
        }

        string idBill;
        public f_HoaDon(string idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
        }

        DataTable dtDetailBill = new DataTable();
        ChiTietHoaDon dbDBill = new ChiTietHoaDon();
        HoaDon dbBill = new HoaDon();
        
        private void f_HoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dtDetailBill.Clear();
                DataSet ds = dbBill.getDetailBill(idBill);
                dtDetailBill = ds.Tables[0];
                dgv_DetailBill.DataSource = dtDetailBill;
                DataRow dr = dbBill.getBillBasic(idBill);
                lbl_TenNhanVien.Text = dr[0].ToString();
                lbl_TenKhachHang.Text = dr[1].ToString();
                DateTime ngaylap = (DateTime)dr[2];
                lbl_NgayLap.Text = ngaylap.ToString("dd/MM/yyyy");
                lbl_MaHoaDon.Text = dr[3].ToString();
                lbl_TongTien.Text = dbDBill.getTongThanhToan().ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Chưa có hóa đơn nào");
            }
        }
    }
}