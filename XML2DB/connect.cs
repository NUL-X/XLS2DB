using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace XML2DB
{
    class Connection
    {
        static string ConnectionString;
        static SqlConnection con;

        public object ConfigurationManager { get; private set; }

        public Connection(string cs)
        {
            ConnectionString = cs;
        }
        public Connection()
        {

        }

        public void OpenConection()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                MessageBox.Show("Connection Successfully!!");
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


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
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
            try
            {
                string ConString = ConnectionString;
                string CmdString = "SELECT * FROM " + tableName + " FOR XML RAW('" + tableName + "'), ROOT('" + tableName + "'), ELEMENTS";
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataTable dt;
                using (con = new SqlConnection(ConString))
                {
                    cmd = new SqlCommand(CmdString, con);
                    con.Open();
                    dt = new DataTable(tableName);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dt.WriteXml(tableName+".xml");
                    con.Close();
                    MessageBox.Show("XMLWriting is successful!!");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
