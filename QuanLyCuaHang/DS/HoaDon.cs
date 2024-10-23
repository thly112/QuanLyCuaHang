using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Common;

namespace QuanLyCuaHang.DS
{
    internal class HoaDon
    {
        DBConnection db;
        SqlCommand comm;

        public HoaDon() 
        {
            db = new DBConnection();
        }

        public DataSet getBill()
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("Select * from v_HoaDon", db.getSqlConn);
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
        
        public DataRow getBillBasic(string bid)
        {
            //db.openConnection();
            //DataSet ds = new DataSet();
            //try
            //{
            //    comm = new SqlCommand("Select * from v_NhanVien_KhachHang Where [Mã hóa đơn] = @bid", db.getSqlConn);
            //    comm.Parameters.AddWithValue("@bid",bid);
            //    SqlDataAdapter da = new SqlDataAdapter();
            //    da.SelectCommand = comm;
            //    da.Fill(ds);
            //    DataRow dr = ds.Tables[0].Rows[0];
            //    return dr;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return null;
            //}
            //finally
            //{
            //    db.closeConnection();
            //}
            DataSet ds = db.ExecuteQueryDataSet(string.Format("select * from v_NhanVien_KhachHang where b_id = '{0}'", bid));
            DataRow dr = ds.Tables[0].Rows[0];
            return dr;
        }
        public DataSet getDetailBill(string bid)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {

                return db.ExecuteQueryDataSet(string.Format("select * from v_ChiTietHoaDon where [Mã hóa đơn] = '{0}'", bid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
            return ds;
        }
        public DataSet find(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                db.openConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
            return ds;
        }
        public DataSet findByBillId(string id)
        {
            comm = new SqlCommand("Select * from dbo.fn_TimHDTheoMaHD(@id)", db.getSqlConn);
            comm.Parameters.AddWithValue ("@id", id);
            return find(comm);
        }
        public DataSet findByProductId(string id)
        {
            comm = new SqlCommand("Select * from dbo.fn_TimHDTheoMaSP(@id)", db.getSqlConn);
            comm.Parameters.AddWithValue("@id", id);
            return find(comm);
        }
        public DataSet findByDate(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            comm = new SqlCommand("Select * from dbo.fn_TimHDTheoNgay (@ngayBatDau,@ngayKetThuc)", db.getSqlConn);
            comm.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
            comm.Parameters.AddWithValue("@ngayKetThuc", ngayKetThuc);
            return find(comm);
        }
        public DataSet findByPhone(string sdt)
        {
            comm = new SqlCommand("Select * from dbo.fn_TimHDTheoSDT(@sdt)", db.getSqlConn);
            comm.Parameters.AddWithValue("@sdt", sdt);
            return find(comm);
        }
        public bool addBill(string bid, DateTime date, decimal total, decimal discount, string cphone, string eid)
        {
            db.openConnection();
            try
            {
                comm = new SqlCommand("Exec sp_ThemHoaDon @bid, @date, @total, @discount, @cphone, @eid", db.getSqlConn);
                comm.Parameters.AddWithValue("@bid", bid);
                comm.Parameters.AddWithValue("@date",date);
                comm.Parameters.AddWithValue("@total", total);
                comm.Parameters.AddWithValue("@discount", discount);
                comm.Parameters.AddWithValue("@cphone", cphone);
                comm.Parameters.AddWithValue("@eid", eid);
                int result = comm.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool deleteBill(string bid)
        {
            db.closeConnection();
            try
            {
                comm = new SqlCommand("Exec sp_XoaHoaDon @bid", db.getSqlConn);
                comm.Parameters.AddWithValue("@bid", bid);
                int result = comm.ExecuteNonQuery();
                return result > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public string createAutoID()
        {
            db.openConnection();
            try
            {
                comm = new SqlCommand("sp_TaoMaHDTuDong", db.getSqlConn);
                comm.CommandType = CommandType.StoredProcedure;
                object result = comm.ExecuteScalar();
                if(result != null)
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally 
            { 
                db.closeConnection(); 
            }
            return "";
        }
        public int totalProductSell(int nOfDays)
        {
            db.openConnection();
            int result = 0;
            try
            {
                comm = new SqlCommand("Select dbo.fn_TinhSoSPDaBan(@nOfDays)", db.getSqlConn);
                comm.Parameters.AddWithValue("@nOfDays", nOfDays);
                if (comm.ExecuteScalar() != DBNull.Value)
                {
                    result = (int)comm.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
            return result;
        }
        public decimal totalSellFee(int nOfDays)
        {
            db.openConnection();
            decimal result = 0;
            try
            {
                comm = new SqlCommand("Select dbo.fn_TinhTienBanHang(@nOfDays)", db.getSqlConn);
                comm.Parameters.AddWithValue("@nOfDays", nOfDays);
                result = Convert.ToDecimal(comm.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
            return result;
        }
    }
}
