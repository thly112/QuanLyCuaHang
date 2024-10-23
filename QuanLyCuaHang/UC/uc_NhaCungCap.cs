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
    public partial class uc_NhaCungCap : UserControl
    {
        public uc_NhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap dbSupplier = new NhaCungCap();
        DataTable dtSupplier = new DataTable();
        private void us_supplier_Load(object sender, EventArgs e)
        {
            loadSupplier();
           // btn_LamMoi_Click(sender, e);
        }
        public void loadSupplier()
        {
            try
            {
                dtSupplier.Clear(); //clear datatable
                DataSet ds = dbSupplier.getNhaCungCap();
                dtSupplier = ds.Tables[0];
                dgv_supplier.DataSource = dtSupplier;

            }
            catch (SqlException)
            {
                MessageBox.Show("Chưa có nhà cung cấp nào");
            }
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            loadSupplier(); 
        }
        private void btn_themMoi_Click(object sender, EventArgs e)
        {
            string auto_id = dbSupplier.createAutoId(); //s_id duoc tao tu dong
            try
            {
                if (dbSupplier.addSupplier(auto_id, txt_tenSupplier.Text.Trim(), txt_SDTSupplier.Text.Trim(), txt_diaChiSupplier.Text.Trim()))
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    loadSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkTxt()
        {
            if (txt_tenSupplier.Text.Trim() != ""
                && txt_diaChiSupplier.Text.Trim() != ""
                && txt_SDTSupplier.Text.Trim() != "")
            {
                return true;
            }
            else return false; //if textbox = ""
        }
        private void btn_chinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgv_supplier.CurrentRow;
            //string s_id = (string)currentRow.Cells[0].Value; //s_id
            txt_tenSupplier.Text = (string)currentRow.Cells[1].Value;
            txt_SDTSupplier.Text = (string)currentRow.Cells[2].Value;
            txt_diaChiSupplier.Text = (String)currentRow.Cells[3].Value;
            btn_themMoi.Enabled = false;
            btn_capNhat.Enabled = true;
        }
        private void btn_capNhat_Click(object sender, EventArgs e)
        {

            DataGridViewRow currentRow = dgv_supplier.CurrentRow;
            string currentRow_id = (string)currentRow.Cells[0].Value; //lay s_id tu datagridview

            try
            {
                if (dbSupplier.updateSupplier(currentRow_id, txt_tenSupplier.Text.Trim(), txt_SDTSupplier.Text.Trim(), txt_diaChiSupplier.Text.Trim()))
                {
                    MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    loadSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgv_supplier.CurrentRow;
            string currentRow_id = (string)currentRow.Cells[0].Value; //lay s_id tu datagridview
            DialogResult respone = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp có ID: " + currentRow_id, "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //Nếu đồng ý
            if (respone == DialogResult.Yes)
            {
                if (dbSupplier.deleteSupplier(currentRow_id))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            loadSupplier();
            btn_LamMoi_Click(sender, e);
        }

        private void LamMoi()
        {
            txt_tenSupplier.Text = "";
            txt_SDTSupplier.Text = "";
            txt_diaChiSupplier.Text = "";
            btn_themMoi.Enabled = true;
            btn_capNhat.Enabled = false;
        }
    }
}
