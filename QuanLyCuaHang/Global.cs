using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang
{
    internal class Global
    {
        private static string _username;
        private static string _password;

        public static string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrEmpty(_username))
                {
                    _username = value;
                }
            }
        }

        public static string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(_password))
                {
                    _password = value;
                }
            }
        }
    }
}
