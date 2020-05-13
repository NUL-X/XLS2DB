using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XML2DB
{
    public partial class xlsToDGV : UserControl
    {
        public bool dbTb = false;
        public bool pnSave = false;
        public bool ActivateMod = false;
        ExportImportClass dbx = new ExportImportClass();
        private bool sqlsave = false;

        public xlsToDGV()
        {
            
            InitializeComponent();
            this.dg_SQL.AllowUserToAddRows = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.tb_search.Text = "";
            btn_Cancel.Visible = false;
            this.dg_SQL.ClearSelection();
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            btn_Cancel.Visible = true;

            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = tb_search.Text;

                dg_SQL.SelectionMode = DataGridViewSelectionMode.CellSelect;
                try
                {
                    foreach (DataGridViewRow row in dg_SQL.Rows)
                    {
                        foreach (DataGridViewColumn col in dg_SQL.Columns)
                        {
                            if (row.Cells[col.Index].Value.ToString().Equals(searchValue))
                            {

                                dg_SQL.Rows[row.Index].Cells[col.Index].Selected = true;
                                dg_SQL.Focus();
                                break;
                            }
                            else
                            {
                                // dg_SQL.Rows[row.Index].Cells[col.Index].ClearSelection();
                                dg_SQL.Rows[row.Index].Cells[col.Index].Selected = false;
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "" || tb_search.Text == null)
            {
                btn_Cancel.Visible = false;
            }
            else
            {
                btn_Cancel.Visible = true;
            }
        }

        private void btn_dbTbl_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xls",
                Filter = "xls files (*.xls)|*.xls| xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

              
                dbx.XLS2XML(openFileDialog1.FileName);
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"ThisisXML.xml");
                this.dg_SQL.DataSource = dataSet.Tables[0];

            }
        }

        private void btn_save_xls_Click(object sender, EventArgs e)
        {
            string tableName = "Xls2Xls";
            dbx.DGV2XLS(this.dg_SQL, tableName);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string tableName = DataBaseToDGVUserCtrl.cb_tbSelect;


            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dbx.SaveDGtoXML(dg_SQL, Path.Combine(fbd.SelectedPath, "XLS2XML.xml"));

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dg_SQL.Rows.Count != 0)
            {
                try
                {
                    DataTable ds = (DataTable)dg_SQL.DataSource;

                    DataRow dr = ds.NewRow();
                    //index is selected row's index
                    var index = dg_SQL.Rows.Count + 1;
                    ds.Rows.InsertAt(dr, index);

                    dg_SQL.DataSource = ds;



                    //select the last row 

                    dg_SQL.Rows[index - 1].Selected = true;
                    dg_SQL.Rows[index - 1].Cells[0].Selected = true;

                    //In case if you want to scroll down as well.
                    dg_SQL.FirstDisplayedScrollingRowIndex = index - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dg_SQL.Rows.Count != 0)
            {
                foreach (DataGridViewCell oneCell in dg_SQL.SelectedCells)
                {
                    if (oneCell.Selected)
                        dg_SQL.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dg_SQL.Rows.Count != 0)
            {
                if (!ActivateMod)
                {
                    ActivateMod = true;
                    dg_SQL.ReadOnly = false;
                    dg_SQL.BeginEdit(true);
                    this.lb_editOn.Visible = true;
                
                }
                else
                {
                    ActivateMod = false;
                    //dg_SQL.CurrentRow.ReadOnly = true;
                    dg_SQL.BeginEdit(false);
                    dg_SQL.ReadOnly = true;
                    this.lb_editOn.Visible = false;

                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pnSave)
            {
                this.pn_save.Visible = false;
                pnSave = false;
            }
            else
            {
                this.pn_save.Visible = true;
                pnSave = true;
            }
        }

        private void btn_save_db_Click(object sender, EventArgs e)
        {
            if (sqlsave)
            {
                this.xlsDB1.Visible = false;
                this.btn_SaveToDB.Visible = false;
                sqlsave = false;
            }
            else
            { 
                this.btn_SaveToDB.Visible = true;
                this.xlsDB1.Visible = true;
               
                sqlsave = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbx.DGV2DB(dg_SQL, xlsToDGVUserCtrl.cb_tbSelect1);

            MessageBox.Show("Added Successfully to your DataBase", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xlsDB1_VisibleChanged(object sender, EventArgs e)
        {
            if (xlsDB1.Visible)
            {
                this.btn_SaveToDB.Visible = true;
                sqlsave = true;
            }
            else
            {
                this.btn_SaveToDB.Visible = false;
                sqlsave = false;
            }
        }

        private void dg_SQL_SelectionChanged(object sender, EventArgs e)
        {
            if (lb_editOn.Visible.Equals(true))
            {
                lb_editOn.Visible = false;
                ActivateMod = false;
            }
        }

        private void dg_SQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(lb_editOn.Visible.Equals(true))
                {
                    lb_editOn.Visible = false;
                    ActivateMod = false;
                }
            }
        }

        private void dg_SQL_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (lb_editOn.Visible.Equals(true))
            {
                lb_editOn.Visible = false;
                ActivateMod = false;
                
            }
        }
    }
    }
