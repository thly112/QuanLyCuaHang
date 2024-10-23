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
    internal class ChiTietLoHang
    {
        DBConnection db;
        SqlCommand cmd;
        public ChiTietLoHang()
        {
            db = new DBConnection();
        }
        public DataSet getDetailShipment(string id)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                
                cmd = new SqlCommand("Select * from v_ChiTietLoHang Where [Mã lô hàng] = @id", db.getSqlConn);
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
        public bool addDetailShipment(string shid, string pid, decimal imPrice, int quantity)
        {
            cmd = new SqlCommand("EXEC sp_ThemChiTietLo @shid, @pid, @imPrice, @quantity", db.getSqlConn);
            cmd.Parameters.AddWithValue("@shid", shid);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@imPrice", imPrice);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
