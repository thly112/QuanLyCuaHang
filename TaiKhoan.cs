using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class TaiKhoan
{
	public TaiKhoan()
	{
        DBConnection db;
        SqlCommand comm;

        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string eid { get; set; }

        public Account(string username, string password, string name, string eid)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.eid = eid;
        }

        public Account()
        {
            db = new DBConnection();
        }


        public DataSet getAccount()
        {
            return db.ExecuteQueryDataSet("select * from V_INFO_ACCOUNT");
        }

        public bool testLogin(string username, string password)
        {
            db.openConnection();
            comm = new SqlCommand("SELECT dbo.uf_CheckLogin(@a_username, @a_password)", db.getSqlConn);
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
            return db.ExecuteQueryDataSet("Select * from dbo.uf_PermissionRole('" + username + "', '" + password + "')");
        }

        public bool addAccount(String username, String password, String eid, int role)
        {
            comm = new SqlCommand("EXEC pro_AddAccount @ausername, @apassword, @eid, @arole", db.getSqlConn);
            comm.Parameters.AddWithValue("@ausername", username);
            comm.Parameters.AddWithValue("@apassword", password);
            comm.Parameters.AddWithValue("@eid", eid);
            comm.Parameters.AddWithValue("@arole", role);

            db.openConnection();
            if (comm.ExecuteNonQuery() > 0)
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

        public bool updateAccount(String username, String password)
        {
            comm = new SqlCommand("EXEC proc_updateAccount @a_username, @a_password", db.getSqlConn);
            comm.Parameters.AddWithValue("@a_username", username);
            comm.Parameters.AddWithValue("@a_password", password);

            db.openConnection();
            if (comm.ExecuteNonQuery() > 0)
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
        public DataSet findAccountByID(string id)
        {
            db.openConnection();

            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("SELECT * FROM dbo.SearchAccountByID(@id)", db.getSqlConn);
                comm.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
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
        public DataSet findAccountByUserName(string name)
        {
            db.openConnection();

            DataSet ds = new DataSet();
            try
            {
                comm = new SqlCommand("SELECT * FROM dbo.SearchAccountByUserName(@name)", db.getSqlConn);
                comm.Parameters.AddWithValue("@name", name);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
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
