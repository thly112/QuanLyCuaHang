using QuanLyCuaHang.DS;
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
    public partial class uc_KhachHang : UserControl
    {
        public uc_KhachHang()
        {
            InitializeComponent();
        }

        bool addFlag;
        DataTable dtCustomer = new DataTable();
        DataTable dtCustomerInactive = new DataTable();
        KhachHang dbCustomer = new KhachHang();
        private void uc_KhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadCustomerInactive();
            trangThai_banDau();
        }
        public void LoadCustomer()
        {
            dtCustomer.Clear();
            DataSet ds = dbCustomer.getCustomer();
            dtCustomer = ds.Tables[0];
            dgv_DanhSachHD.DataSource = dtCustomer;
            setDataGridView();
        }
        private void setDataGridView()
        {
            if (dgv_DanhSachHD != null)
            {
                //Set Header Text cho dtgv
                dgv_DanhSachHD.Columns[0].HeaderText = "Số điện thoại";
                dgv_DanhSachHD.Columns[1].HeaderText = "Tên";
                dgv_DanhSachHD.Columns[2].HeaderText = "Điểm";

                //Set chiều rộng cột
                int width = dgv_DanhSachHD.Width;
                int n_column = dgv_DanhSachHD.ColumnCount;
                dgv_DanhSachHD.Columns[0].Width -= width / n_column;
                dgv_DanhSachHD.Columns[1].Width -= width / n_column;
                dgv_DanhSachHD.Columns[2].Width -= width / n_column;
                dgv_DanhSachHD.AutoResizeColumns();
            }
        }

        public void LoadCustomerInactive()
        {
            dtCustomerInactive.Clear();
            DataSet ds = dbCustomer.getCustomerInactive();
            dtCustomerInactive = ds.Tables[0];
            dgv_DanhSachKHD.DataSource = dtCustomerInactive;
            setDataGridViewInactive();
        }
        private void setDataGridViewInactive()
        {
            if (dgv_DanhSachKHD != null)
            {
                //Set Header Text cho dtgv
                dgv_DanhSachKHD.Columns[0].HeaderText = "Số điện thoại";
                dgv_DanhSachKHD.Columns[1].HeaderText = "Tên";
                dgv_DanhSachKHD.Columns[2].HeaderText = "Điểm";
                //Set chiều rộng cột
                int width = dgv_DanhSachKHD.Width;
                int n_column = dgv_DanhSachKHD.ColumnCount;
                dgv_DanhSachKHD.Columns[0].Width -= width / n_column;
                dgv_DanhSachKHD.Columns[1].Width -= width / n_column;
                dgv_DanhSachKHD.Columns[2].Width -= width / n_column;
                dgv_DanhSachKHD.AutoResizeColumns();
            }
        }

        void trangThai_khongNhap()
        {
            txt_SoDienThoai.Enabled = false;
            txt_TenKhachHang.Enabled = false;
            txt_DiemTichLuy.Enabled = false;
            rb_HD.Enabled = false;
            rb_KhongHD.Enabled = false;
        }
       
        void trangThai_Nhap()
        {
            txt_SoDienThoai.Enabled = true;
            txt_TenKhachHang.Enabled = true;
            txt_DiemTichLuy.Enabled = true;
            rb_HD.Enabled = true;
            rb_KhongHD.Enabled = true;
        }
       
        void trangThai_banDau()
        {
            trangThai_khongNhap();
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        
        private void lamMoi()
        {
            txt_SoDienThoai.Text = "";
            txt_TenKhachHang.Text = "";
            txt_DiemTichLuy.Text = "";
            rb_HD.Checked = false;
            rb_KhongHD.Checked = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            dgv_DanhSachKHD.Visible = true;
            dgv_DanhSachHD.Visible = true;
            dgv_TimKiem.Visible = false;
            lbl_HD.Visible = true;
            lbl_TimKiem.Visible = false;
            txt_TimTheoSDT.Text = "Theo số điện thoại";
            txt_TimTheoTen.Text = "Theo tên khách hàng";
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_DiemTichLuy.Text == "" || Decimal.Parse(txt_DiemTichLuy.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập điểm và không âm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (addFlag == true) //Trường hợp thêm Khách hàng
            {
                try
                {
                    dbCustomer.addCustomer(txt_SoDienThoai.Text.Trim(), txt_TenKhachHang.Text.Trim(),
                        //Lấy giá trị điểm trong Textbox, nếu textbox không có dữ liệu thì cho nó bằng 0
                        (int)Convert.ToDecimal(txt_DiemTichLuy.Text.Trim()));
                    LoadCustomer();
                    LoadCustomerInactive();
                    Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Refresh();
                }
                addFlag = false;
            }
            else //Trường hợp người dùng nhấn update
            {
                bool check = rb_HD.Checked ? true : false;
                try
                {
                    dbCustomer.updateCustomer(
                        txt_SoDienThoai.Text.Trim(),
                        txt_TenKhachHang.Text.Trim(),
                        //Lấy giá trị điểm trong Textbox, nếu textbox không có dữ liệu thì cho nó bằng 0
                        (int)Convert.ToDecimal(txt_DiemTichLuy.Text.Trim()), check);
                    LoadCustomer();
                    LoadCustomerInactive();
                    lamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lamMoi();
                }
            }
            trangThai_banDau();
        }

        private void pb_TimTheoSDT_Click(object sender, EventArgs e)
        {
            if (txt_TimTheoSDT.Text != "" && txt_TimTheoSDT.Text != null && txt_TimTheoSDT.Text != "Theo số điện thoại")
            {
                btn_Them.Enabled = false;
                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                try
                {
                    DataSet ds = dbCustomer.findCustomerByPhone(txt_TimTheoSDT.Text.Trim());

                    dgv_DanhSachKHD.Visible = false;
                    dgv_DanhSachHD.Visible = false;
                    lbl_HD.Visible = false;
                    lbl_TimKiem.Visible = true;
                    dgv_TimKiem.Visible = true;
                    dtCustomer = ds.Tables[0];
                    if (dtCustomer.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thông tin khách hàng");
                    //else
                    //    MessageBox.Show("Tìm thông tin khách hàng thành công");
                    dgv_TimKiem.DataSource = dtCustomer;

                    // Thực hiện các cài đặt DataGridView (nếu cần)
                    setDataGridViewTimKiem();
                    txt_TimTheoSDT.Text = "Theo số điện thoại";
                    txt_TimTheoTen.Text = "Theo tên khách hàng";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pb_TimKiemTheoTen_Click(object sender, EventArgs e)
        {

            if (txt_TimTheoTen.Text != "" && txt_TimTheoTen.Text != null && txt_TimTheoTen.Text != "Theo tên khách hàng")
            {
                btn_Them.Enabled = false;
                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                try
                {
                    DataSet ds = dbCustomer.findCustomerByName(txt_TimTheoTen.Text.Trim());

                    dgv_DanhSachKHD.Visible = false;
                    dgv_DanhSachHD.Visible = false;
                    lbl_HD.Visible = false;
                    lbl_TimKiem.Visible = true;
                    dgv_TimKiem.Visible = true;
                    dtCustomer = ds.Tables[0];
                    if (dtCustomer.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thông tin khách hàng");
                    //else
                    //    MessageBox.Show("Tìm thông tin khách hàng thành công");
                    dgv_TimKiem.DataSource = dtCustomer;

                    // Thực hiện các cài đặt DataGridView (nếu cần)
                    setDataGridViewTimKiem();
                    txt_TimTheoSDT.Text = "Theo số điện thoại";
                    txt_TimTheoTen.Text = "Theo tên khách hàng";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void setDataGridViewTimKiem()
        {
            if (dgv_TimKiem != null)
            {
                //Set Header Text cho dtgv
                dgv_TimKiem.Columns[0].HeaderText = "Số điện thoại";
                dgv_TimKiem.Columns[1].HeaderText = "Tên";
                dgv_TimKiem.Columns[2].HeaderText = "Điểm";
                dgv_TimKiem.Columns[3].HeaderText = "Hoạt động";
                //Set chiều rộng cột
                int width = dgv_DanhSachHD.Width;
                int n_column = dgv_DanhSachHD.ColumnCount;
                dgv_TimKiem.Columns[0].Width -= width / n_column;
                dgv_TimKiem.Columns[1].Width -= width / n_column;
                dgv_TimKiem.Columns[2].Width -= width / n_column;
                dgv_TimKiem.Columns[3].Width -= width / n_column;
                dgv_TimKiem.AutoResizeColumns();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            lamMoi();
            trangThai_banDau();
            addFlag = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            addFlag = true;
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Sua.Enabled = false;

            //Mở các ô cho phép điền thông tin\
            trangThai_Nhap();
            lamMoi();
            rb_HD.Enabled = false;
            rb_KhongHD.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Trường hợp khi người dùng chưa chọn Khách hàng cần sửa thông tin
            if (txt_SoDienThoai.Text == "" || txt_SoDienThoai.Text == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần chỉnh sửa thông tin", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Sua.Enabled = true;

            //Mở các ô cho phép điền thông tin\
            trangThai_Nhap();
            txt_SoDienThoai.Enabled = false;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text == "" || txt_SoDienThoai.Text == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Hỏi người dùng là có chắc chắn muốn xóa khách hàng không
            DialogResult respone = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //Nếu đồng ý
            if (respone == DialogResult.Yes)
            {
                try
                {
                    dbCustomer.deleteCustomer(txt_SoDienThoai.Text);
                    LoadCustomer();
                    LoadCustomerInactive();
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Refresh();
                }
            }
            else
            {
                Refresh();
                return;
            }
        }

        private void dgv_DanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                txt_SoDienThoai.Text = dgv_DanhSachHD.Rows[numrow].Cells[0].Value.ToString();
                txt_TenKhachHang.Text = dgv_DanhSachHD.Rows[numrow].Cells[1].Value.ToString();
                txt_DiemTichLuy.Text = dgv_DanhSachHD.Rows[numrow].Cells[2].Value.ToString();
                rb_HD.Checked = true;
            }
        }
        private void dgv_DanhSachKHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                txt_SoDienThoai.Text = dgv_DanhSachKHD.Rows[numrow].Cells[0].Value.ToString();
                txt_TenKhachHang.Text = dgv_DanhSachKHD.Rows[numrow].Cells[1].Value.ToString();
                txt_DiemTichLuy.Text = dgv_DanhSachKHD.Rows[numrow].Cells[2].Value.ToString();
                rb_KhongHD.Checked = true;
            }
        }

        private void dgv_TimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                txt_SoDienThoai.Text = dgv_TimKiem.Rows[numrow].Cells[0].Value.ToString();
                txt_TenKhachHang.Text = dgv_TimKiem.Rows[numrow].Cells[1].Value.ToString();
                txt_DiemTichLuy.Text = dgv_TimKiem.Rows[numrow].Cells[2].Value.ToString();
                rb_HD.Checked = Convert.ToInt32(dgv_TimKiem.Rows[numrow].Cells[3].Value) == 1 ? true : false;
                rb_KhongHD.Checked = !rb_HD.Checked;
            }
        }
        private void txt_TimTheoSDT_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoSDT.Text == "Theo số điện thoại")
            {
                txt_TimTheoSDT.Text = "";
            }
        }

        private void txt_TimTheoSDT_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoSDT.Text == "")
            {
                txt_TimTheoSDT.Text = "Theo số điện thoại";
            }
        }

        private void txt_TimTheoTen_Enter(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "Theo tên khách hàng")
            {
                txt_TimTheoTen.Text = "";
            }
        }

        private void txt_TimTheoTen_Leave(object sender, EventArgs e)
        {
            if (txt_TimTheoTen.Text == "")
            {
                txt_TimTheoTen.Text = "Theo tên khách hàng";
            }
        }
    }
}
