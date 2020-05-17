using System;
using System.Data;
using System.Data.SqlClient;

namespace XML2DB
{
    public class ODBConnection
    {
        private static SqlConnection cn = null;
        private static SqlCredential sc;
        private static string _host, _dbName, _user, _password;
        public static bool winAuth = false;
        private static string _connectionString
        {
            get => winAuth ? $@"Data Source=. ;Initial Catalog=${_dbName};Integrated Security = true" : $@"Data Source=.;Initial Catalog=${_dbName};User ID=${_user};Password=${_password}";
            set
            {
                _dbName = value.Split(':')[0];
                _user = winAuth ? value.Split(':')[1] : String.Empty;
                _password = winAuth ? value.Split(':')[2] : String.Empty;
                _ = winAuth
                    ? $@"Data Source=.;Initial Catalog=${_dbName};Integrated Security = true"
                    : $@"Data Source=.;Initial Catalog=${_dbName};User ID=${_user};Password=${_password}";
            }
        }

        public static SqlConnection getConnection()
        {
            // TODO : Implement connection
            if (cn == null || cn.State == ConnectionState.Broken || cn.State == ConnectionState.Closed)
            {
                using (cn = new SqlConnection(_connectionString))
                {
                    cn.Open();
                }
            }
            return cn;
        }
    }
}