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
    public partial class uc_DanhSachHoaDon : UserControl
    {
        public uc_DanhSachHoaDon()
        {
            InitializeComponent();
        }

        Panel pnl_trangchinh;
        public uc_DanhSachHoaDon(Panel pnl_trangchinh)
        {
            InitializeComponent();
            this.pnl_trangchinh = pnl_trangchinh;
        }

        DataTable dtBill = new DataTable();
        HoaDon dbBill = new HoaDon();

        private void uc_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadHistoryBill();
        }
        public void LoadHistoryBill()
        {
            try
            {
                dtBill.Clear();
                DataSet ds = dbBill.getBill();
                dtBill = ds.Tables[0];
                dgv_historyPayment.DataSource = dtBill;
            }
            catch (SqlException)
            {
                MessageBox.Show("Chưa có hóa đơn nào");
            }
        }

        string idbill;
        private void dgv_historyPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_historyPayment.CurrentRow.Index;
            idbill = dgv_historyPayment.Rows[i].Cells[0].Value.ToString();
        }
        private void SetDefaultTextValues()
        {
            txt_timTheoMaHoaDon.Text = "Theo mã hóa đơn";
            txt_timTheoSDT.Text = "Theo SĐT khách hàng";
            txt_timTheoMaMatHang.Text = "Theo mã mặt hàng";
        }
        private void txt_timTheoMaHoaDon_Enter(object sender, EventArgs e)
        {
            SetDefaultTextValues();
            txt_timTheoMaHoaDon.Text = string.Empty;
        }
        private void txt_timTheoSDT_Enter(object sender, EventArgs e)
        {
            SetDefaultTextValues();
            txt_timTheoSDT.Text = string.Empty;
        }
        private void txt_timTheoMaMatHang_Enter(object sender, EventArgs e)
        {
            SetDefaultTextValues();
            txt_timTheoMaMatHang.Text = string.Empty;
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgv_historyPayment.CurrentRow;
            string b_id = (string)currentRow.Cells[0].Value;
            f_HoaDon frm_detail = new f_HoaDon(idbill);
            TienIch.addForm(frm_detail, pnl_trangchinh);

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            SetDefaultTextValues();
            dtp_mocDau.Value = DateTime.Today;
            dtp_mocSau.Value = DateTime.Today;
            LoadHistoryBill();
        }

        private void btn_ApDung_Click(object sender, EventArgs e)
        {
            dtBill.Clear();
            DataSet ds = dbBill.findByDate(dtp_mocDau.Value, dtp_mocSau.Value);
            dtBill = ds.Tables[0];
            dgv_historyPayment.DataSource = dtBill;
            SetDefaultTextValues();
        }

        private void pic_timMaHoaDon_Click(object sender, EventArgs e)
        {
            dtBill.Clear();
            DataSet ds = dbBill.findByBillId(txt_timTheoMaHoaDon.Text);
            dtBill = ds.Tables[0];
            dgv_historyPayment.DataSource = dtBill;
        }

        private void pic_timSĐT_Click(object sender, EventArgs e)
        {
            dtBill.Clear();
            DataSet ds = dbBill.findByPhone(txt_timTheoSDT.Text);
            dtBill = ds.Tables[0];
            dgv_historyPayment.DataSource = dtBill;
        }

        private void pic_timmamathang_Click(object sender, EventArgs e)
        {
            dtBill.Clear();
            DataSet ds = dbBill.findByProductId(txt_timTheoMaMatHang.Text);
            dtBill = ds.Tables[0];
            dgv_historyPayment.DataSource = dtBill;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //XoaHoaDon();
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa hóa đơn?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbBill.deleteBill(idbill);
                    // Cập nhật lại DataGridView 
                    LoadHistoryBill();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");

                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
        //private void XoaHoaDon()
        //{
        //    try
        //    {
        //        DialogResult traloi;
        //        traloi = MessageBox.Show("Xác nhận xóa hóa đơn?", "Trả lời",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (traloi == DialogResult.Yes)
        //        {
        //            HoaDon.xoaHoaDon(idbill);
        //            // Cập nhật lại DataGridView 
        //            LoadHistoryBill();
        //            // Thông báo 
        //            MessageBox.Show("Đã xóa xong!");

        //        }
        //        else
        //        {
        //            // Thông báo 
        //            MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
        //        }
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Không xóa được. Lỗi rồi!");
        //    }
        //}
    }
}
