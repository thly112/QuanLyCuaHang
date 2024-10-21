using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.DS
{
    public class TaiKhoan
    {
        DBConnection db;
        SqlCommand comm;

        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string eid { get; set; }
        public TaiKhoan(string username, string password, string name, string eid)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.eid = eid;
        }

        public TaiKhoan()
        {
            db = new DBConnection();
        }
        public DataSet getAccounts() //lấy bảng chứa tất cả thông tin tài khoản
        {
            //return db.ExecuteQueryDataSet("select * from v_TaiKhoan");
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                comm = new SqlCommand("Select * from v_TaiKhoan", db.getSqlConn);
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

        public bool testLogin(string username, string password)
        {
            db.openConnection();
            comm = new SqlCommand("SELECT dbo.fn_KtraDangNhap(@a_username, @a_password)", db.getSqlConn);
            comm.Parameters.AddWithValue("@a_username", username);
            comm.Parameters.AddWithValue("@a_password", password);
            int result = (int)comm.ExecuteScalar();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public DataSet GetAccount(string username, string password)
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {                
                comm = new SqlCommand ("Select * from dbo.fn_XacThucTaiKhoan(@username, @password)", db.getSqlConn);
                comm.Parameters.AddWithValue ("@username", username);
                comm.Parameters.AddWithValue("@password", password);
                
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

        public bool addAccount(String username, String password, String eid, int role)
        {
            db.openConnection();
            try
            {
                comm = new SqlCommand("EXEC sp_ThemTaiKhoan @username, @password, @eid", db.getSqlConn);
                comm.Parameters.AddWithValue ("@username", username);
                comm.Parameters.AddWithValue ("@password", password);
                comm.Parameters.AddWithValue ("@eid", eid);
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
        public bool updateAccount(String username, String password)
        {
            db.openConnection ();
            try
            {
                comm = new SqlCommand("EXEC sp_CapNhatTK @username, @password", db.getSqlConn);
                comm.Parameters.AddWithValue ("@username", username);
                comm.Parameters.AddWithValue ("@password", password);
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
        public DataSet findAccountByID(string id)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("SELECT * FROM dbo.fn_TimTKTheoMaTK(@id)", db.getSqlConn);
                comm.Parameters.AddWithValue("@id", id);

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
        public DataSet findAccountByUserName(string name)
        {
            db.openConnection();

            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("SELECT * FROM dbo.fn_TimTKTheoTen(@name)", db.getSqlConn);
                comm.Parameters.AddWithValue("@name", name);

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
    }
}
