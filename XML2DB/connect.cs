
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using XMLUtils;

namespace XML2DB
{
    class Connection
    {
        static string ConnectionString;
        public static SqlConnection con;
        public static string DBname;


        public object ConfigurationManager { get; private set; }

        public Connection(string cs,string dbName)
        {
            ConnectionString = cs;
            DBname = dbName;
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
            

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName, new SqlConnection(ConnectionString));
            DataTable dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);

            dt.TableName = tableName;
            dt.WriteXml(tableName+".xml");
            //dt.WriteXmlSchema("Schema File Address");
            MessageBox.Show("XMLWriting is successful!!");

        }

        public void DTtoSQL(DataTable dt, string tblName)
        {

            string cnStr = ConnectionString;
            MessageBox.Show(cnStr);
            XmlUtils.export2DB(dt, cnStr, tblName);
        }

        public void ImportXML(string filename)
        {
        }

    }
}
