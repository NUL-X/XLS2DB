using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML2DB;

namespace XMLUtils
{
    public static class XmlUtils
    {
        public static DataSet getXmlData(String xmlDocPath)
        {
            DataSet xmlData = new DataSet();
            xmlData.ReadXml(xmlDocPath);
            return xmlData;
        }

        public static DataSet getXmlData(Stream xmlDoc)
        {
            DataSet xmlData = new DataSet();
            xmlData.ReadXml(xmlDoc);
            return xmlData;
        }

        public static void exportXmlData(DataTable xmlData, String xmlDocPath)
        {
            xmlData.WriteXml(xmlDocPath);
        }


        public static bool export2DB(DataTable xmlData, string TableName)
        {
            bool pass = false;
            using (SqlConnection connection = ODBConnection.getConnection())
            {
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in xmlData.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    bulkCopy.DestinationTableName = TableName;
                    try
                    {
                        bulkCopy.WriteToServer(xmlData);
                        pass = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        pass = false;
                    }
                }
            }

            return pass;
        }


        public static bool export2CSV(DataGridView dgv, string filename)
        {
            bool pass = false;

            var sb = new StringBuilder();
            var headers = dgv.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            System.IO.File.WriteAllText(filename, sb.ToString());
            pass = true;

            return pass;
        }
    }
}