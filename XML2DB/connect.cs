using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using XMLUtils;

namespace XML2DB
{
    class _Connection
    {
        static string ConnectionString;
        public static SqlConnection con;
        public static string DBname;


        public object ConfigurationManager { get; private set; }

        public _Connection(string cs, string dbName)
        {
            ConnectionString = cs;
            DBname = dbName;
        }

        public _Connection()
        {
        }

        public void OpenConection()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                MessageBox.Show("Connection Successfully!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public string[] GetAllTables()
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.Tables", con);
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                result.Add(reader["name"].ToString());
            return result.ToArray();
        }

        public void TableToXml(string tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName, new SqlConnection(ConnectionString));
            DataTable dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);

            dt.TableName = tableName;
            dt.WriteXml(tableName + ".xml");
        }

        public void DTtoSQL(DataTable dt, string tblName)
        {
            XmlUtils.export2DB(dt, tblName);
        }
    }
}