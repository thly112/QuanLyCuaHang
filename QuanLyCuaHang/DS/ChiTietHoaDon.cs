using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.DS
{
    internal class ChiTietHoaDon
    {
        private string bid;
        private string tenNhanVien;
        private string tenKhachHang;
        private DateTime ngayXuat;
        private decimal tongThanhToan;
        DBConnection db;
        SqlCommand comm;
        public ChiTietHoaDon(string bid)
        {
            this.bid = bid;
        }
        public ChiTietHoaDon()
        {
            db = new DBConnection();
        }
        public string getTenNhanVien() { return this.tenNhanVien; }
        public string getTenKhachHang() { return this.tenKhachHang; }
        public DateTime getNgayLap() { return this.ngayXuat; }
        public decimal getTongThanhToan() { return this.tongThanhToan; }
        public DataSet getDetailBill(string bid)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("Select * from v_ChiTietHoaDon Where [Mã hóa đơn] = @bid", db.getSqlConn);
                comm.Parameters.AddWithValue("@bid", bid);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
            return ds;
        }
        public bool addDetailBill(string bid, string pid, int quantity)
        {
            comm = new SqlCommand("EXEC sp_ThemChiTietHD @b_id, @p_id, @db_quantity", db.getSqlConn);
            comm.Parameters.AddWithValue("@b_id", bid);
            comm.Parameters.AddWithValue("@p_id", pid);
            comm.Parameters.AddWithValue("@db_quantity", quantity);

            db.openConnection();
            if (comm.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
