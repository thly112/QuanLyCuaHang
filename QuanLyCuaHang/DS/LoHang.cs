using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCuaHang.DS
{
    internal class LoHang
    {
        DBConnection db;
        SqlCommand cmd;
        public LoHang()
        {
            db = new DBConnection();
        }
        public DataSet getShipment()
        {
            return db.ExecuteQueryDataSet("Select * from v_LoHang_NhaCungCap");

        }
        public DataRow getOneShipment(string id)
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from dbo.LO_HANG Where ma_lo = @id", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool addShipment(string shid, string sid, DateTime imDate)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("EXEC sp_ThemLoHang @shid, @sid, @imDate", db.getSqlConn);
                cmd.Parameters.AddWithValue("@shid", shid);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@imDate", imDate);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { db.closeConnection(); }
        }
        public bool deleteShipment(string shid)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Exec sp_XoaLoHang @shid", db.getSqlConn);
                cmd.Parameters.AddWithValue("@shid", shid);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { db.closeConnection(); }
        }
        public string CreateAutoID()
        {
            
            db.openConnection();
            try
            {
                cmd = new SqlCommand("sp_TaoMaLoTuDong", db.getSqlConn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào nếu cần
                // comm.Parameters.AddWithValue("@parameterName", parameterValue);

                object result = cmd.ExecuteScalar();

                if (result != null)
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
        public Decimal totalImportFee(int numberOfDays)
        {
            db = new DBConnection();
            db.openConnection();
            Decimal totalImportFee = 0;

            try
            {
                cmd = new SqlCommand("SELECT dbo.fn_TongTienNhapHang(@numberOfDays)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@numberOfDays", numberOfDays);

                totalImportFee = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return totalImportFee;
        }
    }
}
