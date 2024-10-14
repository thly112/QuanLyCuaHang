﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public static class TienIch
    {
        static public void addForm(Form form, Panel pnl_trangchinh)
        {
            pnl_trangchinh.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            int x = (pnl_trangchinh.Width - form.Width) / 2;
            int y = (pnl_trangchinh.Height - form.Height) / 2;
            form.Location = new Point(x, y);
            pnl_trangchinh.Controls.Add(form);
            pnl_trangchinh.Tag = form;
            form.Show();
        }
        static public void addUserControl(UserControl userControl, Panel pnl_trangchinh)
        {
            pnl_trangchinh.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            int x = (pnl_trangchinh.Width - userControl.Width) / 2;
            int y = (pnl_trangchinh.Height - userControl.Height) / 2;
            userControl.Location = new Point(x, y);
            pnl_trangchinh.Controls.Add(userControl);
            pnl_trangchinh.Tag = userControl;
            userControl.Show();
        }
        public static Image ConvertByteArraytoImage(byte[] data) //Dùng để chuyển mảng bit ảnh thành ảnh để load lên form
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
