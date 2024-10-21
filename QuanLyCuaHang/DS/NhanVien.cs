using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace QuanLyCuaHang.DS
{
    internal class NhanVien
    {
        DBConnection db;
        SqlCommand cmd;
        public NhanVien() 
        {
            db = new DBConnection();
        }
        public DataSet getEmployee()
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from v_NhanVien", db.getSqlConn);
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
        public bool addEmployee(string id, string name, string phone, string address, string gender)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_ThemNhanVien @id, @name, @phone, @address, @gender", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { db.closeConnection(); }
        }
        public bool updateEmployee(string id, string name, string address, string phone, string gender)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_CapNhatNhanVien @id, @name, @address, @phone, @gender", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { db.closeConnection(); }
        }
        public bool deleteEmployee(string id)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_XoaNhanVien @id", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { db.closeConnection(); }
        }
        public DataSet findEmployeeById(string id)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("Select * from dbo.fn_TimNVTheoMa(@id)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            return ds;
        }
        public DataSet findEmployeeByName(string name)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("Select * from dbo.fn_TimNVTheoTen(@name)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            return ds;
        }
    }
}
