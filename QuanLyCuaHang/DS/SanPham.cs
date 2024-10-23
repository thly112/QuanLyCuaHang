using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCuaHang.DS
{
    internal class SanPham
    {
        DBConnection db;
        SqlCommand cmd;

        public SanPham()
        {
            db = new DBConnection();
        }
        public DataSet getProduct()
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from v_SanPham", db.getSqlConn);
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
        public DataRow getOneProduct(string pid)
        {
            DataSet ds = new DataSet();
            db.openConnection();
            try
            {
                cmd = new SqlCommand("Select * from dbo.SAN_PHAM Where ma_sp = @pid", db.getSqlConn);
                cmd.Parameters.AddWithValue("@pid", pid);
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
        public bool addProduct(string pid, string name, decimal price, byte[] anh, string size, int quantity)
        {
            try
            {
                db.openConnection();
                cmd = new SqlCommand("Exec sp_ThemSanPham @pid, @name, @price, @anh, @size, @quantity", db.getSqlConn);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@anh", anh.ToArray());
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@quantity", quantity);
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
        public bool deleteProduct(string pid)
        {
            try
            {
                cmd = new SqlCommand("Exec sp_XoaSanPham @pid", db.getSqlConn);
                cmd.Parameters.AddWithValue("@pid", pid);
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
        public bool updateProduct(string pid, string name, decimal price, byte[] anh, string size, int quantity)
        {
            try
            {
                cmd = new SqlCommand("Exec sp_CapNhatSanPham @pid, @name, @price, @anh, @size, @quantity", db.getSqlConn);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@anh", anh.ToArray());
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@quantity", quantity);
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
        public string createAutoID(string id)
        {
            db.openConnection();
            try
            {
                cmd = new SqlCommand("sp_TaoMaSPTuDong", db.getSqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", id);
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
            finally { db.closeConnection(); }
            return "";
        }
        public DataSet findProductById(string id)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("Select * from dbo.fn_TimSPTheoMaSP(@id)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            return ds; 
        }
        public DataSet findProductByName(string name)
        {
            db.openConnection();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("Select * from dbo.fn_TimSPTheoMaSP(@name)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            return ds;
        }
        public DataSet getProductBestSeller(int nOfDays)
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("Select * from dbo.fn_TimTop10SanPham(@nOfDays)", db.getSqlConn);
                cmd.Parameters.AddWithValue("@nOfDays", nOfDays);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.closeConnection(); }
            return ds;
        }
        public string GetTypeProduct(string pid)
        {
            Dictionary<string, string> productTypes = new Dictionary<string, string>
            {
                { "PT", "Áo thun" },
                { "PK", "Áo khoác" },
                { "PM", "Áo sơ mi" },
                { "PP", "Áo Polo" },
                { "PJ", "Quần Jean" },
                { "PE", "Quần Tây" },
                { "PS", "Quần Short" },
            };

            foreach (string key in productTypes.Keys)
            {
                if (pid.Contains(key))
                {
                    return productTypes[key];
                }
            }
            return "Không xác định";
        }
        public string getProductList(FlowLayoutPanel panelProduct, FlowLayoutPanel panelProductPay)
        {
            return db.getButtons("select gia, anh, ma_sp from SAN_PHAM Where tthai_sp = 1", panelProduct, panelProductPay);
        }

        public string findProductList(FlowLayoutPanel panelProduct, FlowLayoutPanel panelProductPay, string name)
        {
            String sql = "select gia, anh, ma_sp from SAN_PHAM Where tthai_sp = 1 And ten_sp LIKE '%" + name + "%'";
            return db.getButtons(sql, panelProduct, panelProductPay);
        }
        public string findFilteredProductList(FlowLayoutPanel panelProduct, FlowLayoutPanel panelProductPay, string loai, string kichco)
        {
            // Khởi tạo câu truy vấn SQL cơ bản
            //String sql = "SELECT gia, anh, ma_sp FROM SAN_PHAM WHERE tthai_sp = 1";

            string query = "SELECT gia, anh, ma_sp FROM SAN_PHAM WHERE 1=1"; // Luôn đúng để nối các điều kiện

            // Nếu 'loai' không trống, thêm điều kiện lọc loại sản phẩm
            if (!string.IsNullOrEmpty(loai))
            {
                query += " AND loai = @loai";
            }

            // Nếu 'kichco' không trống, thêm điều kiện lọc kích cỡ sản phẩm
            if (!string.IsNullOrEmpty(kichco))
            {
                query += " AND kichco = @kichco";
            }
            return db.getButtons(query, panelProduct, panelProductPay);
        
        }

    }
}
