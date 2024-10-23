using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCuaHang.DS
{
    internal class NhaCungCap
    {
        DBConnection db;
        SqlCommand cmd;
        public NhaCungCap()
        {
            db = new DBConnection();
        }
        public DataSet getNhaCungCap()
        {
            return db.ExecuteQueryDataSet("Select * from v_NhaCungCap");
        }
        public string createAutoId()
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("sp_TaoMaNCCTuDong", db.getSqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool addSupplier(string s_id, string s_name, string s_phone, string s_address)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("EXEC sp_ThemNhaCungCap @s_id, @s_name, @s_phone, @s_address", db.getSqlConn);
                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.Parameters.AddWithValue("@s_name", s_name);
                cmd.Parameters.AddWithValue("@s_phone", s_phone);
                cmd.Parameters.AddWithValue("@s_address", s_address);
                cmd.ExecuteNonQuery();
                return true;
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
        public bool updateSupplier(string s_id, string s_name, string s_phone, string s_address)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("EXEC sp_CapNhatNhaCungCap @s_id, @s_name, @s_phone, @s_address", db.getSqlConn);
                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.Parameters.AddWithValue("@s_name", s_name);
                cmd.Parameters.AddWithValue("@s_phone", s_phone);
                cmd.Parameters.AddWithValue("@s_address", s_address);
                cmd.ExecuteNonQuery();
                return true;
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
        public bool deleteSupplier(string s_id)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("EXEC sp_XoaNhaCungCap @s_id", db.getSqlConn);
                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.ExecuteNonQuery();
                return true;
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
    }   
}
