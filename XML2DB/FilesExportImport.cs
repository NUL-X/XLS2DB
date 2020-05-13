using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using System.Data.OleDb;
using System.Windows.Forms;

namespace XML2DB
{
    class ConvertXml
    {
        public bool CreateXltoXML(string XmlFile, string XlFile, string RowName)
        {
            bool IsCreated = false;
            try
            {
                System.Data.DataTable dt = GetTableDataXl(XlFile);
                XmlTextWriter writer = new XmlTextWriter(XmlFile, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("tbl_" + RowName);
                List<string> ColumnNames = dt.Columns.Cast<DataColumn>().ToList().Select(x => x.ColumnName).ToList(); // Column Names List  
                List<DataRow> RowList = dt.Rows.Cast<DataRow>().ToList();
                foreach (DataRow dr in RowList)
                {
                    writer.WriteStartElement(RowName);
                    for (int i = 0; i < ColumnNames.Count; i++) // Getting Node Names from DataTable Column Names  
                    {
                        writer.WriteStartElement(ColumnNames[i]);
                        writer.WriteString(dr.ItemArray[i].ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                if (File.Exists(XmlFile))
                    IsCreated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IsCreated;

        }






        // Creating Xml File With Default FileName  
        public bool CreateXltoXML(string XlFile, string RowName)
        {
            bool IsCreated = false;
            try
            {
                string XmlFile = XlFile.Replace(Path.GetExtension(XlFile), "") + ".xml"; // Getting XMl file Name as Excel File Name  
                System.Data.DataTable dt = GetTableDataXl(XlFile);
                XmlTextWriter writer = new XmlTextWriter(XmlFile, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("tbl_" + RowName);
                List<string> ColumnNames = dt.Columns.Cast<DataColumn>().ToList().Select(x => x.ColumnName).ToList(); // Column Names List  
                List<DataRow> RowList = dt.Rows.Cast<DataRow>().ToList();
                foreach (DataRow dr in RowList)
                {
                    writer.WriteStartElement(RowName);
                    for (int i = 0; i < ColumnNames.Count; i++) // Getting Node Names from DataTable Column Names  
                    {
                        writer.WriteStartElement(ColumnNames[i]);
                        writer.WriteString(dr.ItemArray[i].ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                if (File.Exists(XmlFile))
                    IsCreated = true;
            }
            catch (Exception ex)
            {
            }

            return IsCreated;

        }






        private System.Data.DataTable GetTableDataXl(string XlFile)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                string Ext = Path.GetExtension(XlFile);
                string connectionString = "";
                if (Ext == ".xls")
                {   //For Excel 97-03  
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + XlFile + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                {    //For Excel 07 and greater  
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + XlFile + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                cmd.Connection = conn;
                //Fetch Fisrt Sheet Name  
                conn.Open();
                System.Data.DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string ExcelSheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //Read all data from the Sheet to a Data Table  
                conn.Open();
                cmd.CommandText = "SELECT * From [" + ExcelSheetName + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt); // Fill Sheet Data to Datatable  
                conn.Close();
            }
            catch (Exception ex)
            { }

            return dt;
        }
    }
}
