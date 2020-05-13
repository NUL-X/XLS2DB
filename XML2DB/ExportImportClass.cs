using System.Data;
using System.Linq;
using System.Windows.Forms;
using XMLUtils;


using ClosedXML.Excel;
using System.IO;
using System.Data.OleDb;
using OfficeOpenXml;

namespace XML2DB
{
    class ExportImportClass
    {
        Connection con = new Connection();
        public static string connStr ;
        

        public void TableToXML(string tbName)
        {
            con.TableToXml(tbName);

        }



        // Save DataGridView To DataBase
        public void DGV2DB(DataGridView dgv, string tablename)
        {
            DataTable dt = this.DGV2DT(dgv, tablename);
            con.DTtoSQL(dt, tablename);
        }





        public void DGV2XLS(DataGridView dgv, string tablename)
        {
            DataTable dt = this.DGV2DT(dgv, tablename);
            // Export DataTable dt to Excel
           

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                         wb.Worksheets.Add(dt, "Customers");
                        
                        wb.SaveAs(@""+fbd.SelectedPath +"\\"+tablename + ".xlsx");
                    }

                }
            }

        }





        public void DGtoXML(DataGridView xmlDataGrid, string fileName)
        {
            if (xmlDataGrid.ColumnCount > 0)
            {
               XmlUtils.exportXmlData((DataTable)xmlDataGrid.DataSource, fileName + ".xml");

               MessageBox.Show("Xml File is created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                
        }

        public void SaveDGtoXML(DataGridView xmlDataGrid, string fileName)
        {
            if (xmlDataGrid.ColumnCount > 0)
            {
                XmlUtils.exportXmlData((DataTable)xmlDataGrid.DataSource, fileName + ".xml");

                MessageBox.Show("Xml File is created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
      


        public DataTable DGV2DT(DataGridView dgv, string tablename) 
        {

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            dt.TableName = tablename;
            return dt ;
        }

       
        //Convert XLS file to XML
        
        public void XLS2XML(string file)
        {
            DataTable dt = GetDataTableFromExcel(file);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml("ThisisXML.xml");

        }





        public static DataTable GetDataTableFromExcel(string path, bool hasHeader = true)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var pck = new OfficeOpenXml.ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets.First();
                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                return tbl;
            }
        }




    }

    
}


   
