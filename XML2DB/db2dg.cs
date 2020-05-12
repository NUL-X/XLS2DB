using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace XML2DB
{
    public partial class db2dg : UserControl
    {
        public bool dbTb        = false;
        public bool pnSave      = false;
        public bool ActivateMod = false;
        DB2XML dbx = new DB2XML();
        public db2dg()
        {
            InitializeComponent();
            this.dbTables1.Hide();
            this.dg_SQL.AllowUserToAddRows = false;
            this.tb_search.GotFocus += OnFocus;
            

        }


        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void db2dg_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {


            this.Hide();
        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dbTables1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (this.dbTb)
            {
                this.dbTables1.Hide();
                this.dbTb = false;
            }
            else
            {
                this.dbTables1.Show();
                this.dbTb = true;
            }
        }

        public void DG_Write(String tbName)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"" + tbName + ".xml");
            this.dg_SQL.DataSource = dataSet.Tables[0];
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (pnSave)
            {
                this.pn_save.Visible = false;
                this.pnSave = false;

            }
            else
            {
                this.pn_save.Visible = true;
                this.pnSave = true;
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

            string tableName = dbTables.cb_tbSelect;
            dbx.DGV2XLS(dg_SQL, tableName);

        }



        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {

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

        private void dg_SQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.tb_search.Text = "";
            btn_Cancel.Visible = false;
            this.dg_SQL.ClearSelection();
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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

        private void tb_search_OnValueChanged(object sender, EventArgs e)
        {

        }

        

        private void tb_search_MouseClick(object sender, MouseEventArgs e)
        {
            btn_Cancel.Visible = true;
        }
       
        private void OnFocus(object sender, EventArgs e)
        {
           if (tb_search.Text != null || tb_search.Text != "")
            {
                btn_Cancel.Visible = true;
            }
            else
            {
                btn_Cancel.Visible = false;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (dg_SQL.Rows.Count != 0) { 
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
                dg_SQL.ReadOnly=true;
                this.lb_editOn.Visible = false;


            }
            }

        }

        private void dg_SQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dg_SQL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_SQL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ActivateMod)
            {
                MessageBox.Show("You need to activate Edit mode to enable modification", "info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void label1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_db_Click(object sender, EventArgs e)
        {
            string tableName = dbTables.cb_tbSelect;
            dbx.DGV2DB(dg_SQL,tableName);
            MessageBox.Show("Added Successfully to your DataBase","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            string tableName = dbTables.cb_tbSelect;
            

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                   dbx.SaveDGtoXML(dg_SQL, Path.Combine(fbd.SelectedPath,tableName+".xml"));

                }
            }

        }

        private void dg_SQL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pn_editDG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_save_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_editOn_Click(object sender, EventArgs e)
        {

        }

        private void dbTables1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
