using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN.BTN_CONTROLS;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;

namespace QuanLyCuaHang.DB
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=THLY;Initial Catalog=QLCUAHANG;User Id=" + Global.Username + ";Password=" +
Global.Password + ";");
        SqlCommand comm = null; //Đối tượng truy vấn và cập nhật vào SQL Serverwd
        SqlDataAdapter da = null; //Đối tượng đưa dữ liệu vào DataTable

        public SqlConnection getSqlConn //Lấy chuỗi kết nối
        {
            get
            {
                return conn;
            }
        }

        public DBConnection() // Hàm khởi tạo: khởi tạo chuỗi kết nối và đối tượng truy vấn
        {
            comm = conn.CreateCommand();
        }

        public void openConnection() //Mở kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        public void closeConnection() //Đóng kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Close();
            }
        }

        public DataSet ExecuteQueryDataSet(string strSQL) //Lấy data thông qua câu truy vấn đưa vào DataSet --> Load lên DataGridView
        {
            if (conn.State == ConnectionState.Open)//Nếu đang mở kết nối trước đó thì đóng lại
                conn.Close();
            conn.Open(); //Tạo một kết nối mới
            comm.CommandText = strSQL; //Đưa câu truy vấn vào SqlCommand
            da = new SqlDataAdapter(comm); //Khởi tạo một instance mới với SQLcommand đã cho
            DataSet ds = new DataSet();
            da.Fill(ds); //Đưa dữ liệu truy vào Dataset
            return ds;
        }

        public string getButtons(string query, FlowLayoutPanel panelProduct, FlowLayoutPanel panelProductPay)
        {
            string ret = "";

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = query.ToLower();

                SqlDataReader reader = comm.ExecuteReader();

                string price, id;
                Image image;

                while (reader.Read())
                {
                    price = reader[0].ToString();
                    byte[] imageBytes = (byte[])reader[1]; // Đọc dữ liệu hình ảnh từ cột thứ hai
                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        // Tạo một hình ảnh từ MemoryStream
                        image = Image.FromStream(stream);

                        // Bây giờ bạn có thể sử dụng biến 'image' để hiển thị hoặc xử lý hình ảnh.
                        // Ví dụ: pictureBox1.Image = image; (đối với Windows Forms)
                    }
                    id = reader[2].ToString();

                    us_Product btn = new us_Product();

                    btn.ItemPrice = price;
                    btn.ItemImage = image;
                    btn.ItemID = id;
                    btn.Click += (sender, e) => getInformation(btn, panelProductPay);


                    if (price != string.Empty)
                    {
                        panelProduct.Controls.Add(btn);
                    }

                    ret = "Data Fetched Successfully.. :)";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ret;
        }

        public void getInformation(us_Product us_Product, FlowLayoutPanel panel)
        {
            us_Product_Pay productpay = new us_Product_Pay();
            productpay.ItemID = us_Product.ItemID;
            productpay.ItemPrice = us_Product.ItemPrice;

            bool found = false;  // Biến này để kiểm tra xem sản phẩm đã tồn tại trong FlowLayoutPanel chưa.

            foreach (Control control in panel.Controls)
            {
                if (control is us_Product_Pay us_Product_Pay)
                {
                    if (us_Product_Pay.ItemID == productpay.ItemID)
                    {
                        // Nếu sản phẩm đã tồn tại, tăng số lượng lên 1.
                        int temp = int.Parse(us_Product_Pay.ItemQuantity) + 1;
                        us_Product_Pay.ItemQuantity = temp.ToString();
                        found = true;  // Đánh dấu là sản phẩm đã tồn tại.
                        break;  // Bạn có thể thoát khỏi vòng lặp vì bạn đã tăng số lượng sản phẩm.
                    }
                }
            }

            if (!found)
            {
                // Nếu sản phẩm chưa tồn tại trong FlowLayoutPanel, hãy thêm nó vào.
                int horizontalMargin = (panel.Width - productpay.Width) / 2;

                productpay.Margin = new Padding(horizontalMargin, 0, horizontalMargin, 0);
                panel.Controls.Add(productpay);
            }
        }
    }
}
