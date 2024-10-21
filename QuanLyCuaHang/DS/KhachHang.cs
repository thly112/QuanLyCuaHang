using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.DS
{
    internal class KhachHang
    {
        DBConnection db;
        SqlCommand cmd;
        public KhachHang()
        {
            db = new DBConnection();
        }
        public DataSet getCustomer()
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from v_KhachHang", db.getSqlConn);
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
        public DataSet getCustomerInactive()
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from v_KhachHangCu", db.getSqlConn);
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
        public int customerNumber()
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select dbo.fn_TinhSoKhachHang()", db.getSqlConn);
                int result = (int)cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool addCustomer(string phone, string name, decimal point)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Exec sp_ThemKhachHang @phone, @name, @point", db.getSqlConn);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@point", point);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool updateCustomer(string phone, string name, decimal point, bool status)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_CapNhatKhachHang @phone, @name, @point, @status", db.getSqlConn);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@point", point);
                cmd.Parameters.AddWithValue("@status", status);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool deleteCustomer(string phone)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_XoaKhachHang @phone", db.getSqlConn);
                cmd.Parameters.AddWithValue("@phone", phone);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataSet findCustomerByPhone(string phone)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("SELECT * FROM dbo.fn_TimKhachHangTheoSdt(@phone)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@phone", phone);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.closeConnection();
            }

            db.closeConnection();
            return ds;
        }
        public DataSet findCustomerByName(string name)
        {
            db.openConnection();

            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("SELECT * FROM dbo.fn_TimKhachHangTheoTen(@name)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@name", name);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.closeConnection();
            }

            db.closeConnection();
            return ds;
        }
    }
}
