using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML2DB
{
    public partial class XlsDB : UserControl
    {
        public static string connString = null;

        DB2XML dbx = new DB2XML();

        Connection cn;
        Cnx cnx;
        /*
         This variable for comboBox filling the comboBox
         */
        public static string[] tb_names2;
        public static int tb_len = -1;
        public static bool added = false;
        public static string cb_tbSelect1;

        public XlsDB()
        {
            InitializeComponent();
        }

        public XlsDB(string[] tb , int length)
        {
            InitializeComponent();
            tb_names2 = tb;
            tb_len = length;
        }

        private void btn_cnx_Click(object sender, EventArgs e)
        {
            try
            {

                cnx = new Cnx();

                if (Application.OpenForms[cnx.Name] == null)
                {
                    cnx.Show();

                    this.Visible = false;

                }
                else
                {
                    Application.OpenForms[cnx.Name].Focus();
                    Application.OpenForms[cnx.Name].Activate();
                    Application.OpenForms[cnx.Name].BringToFront();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cb_tb_VisibleChanged(object sender, EventArgs e)
        {
            if (tb_len > -1)
            {

                if (!added)
                {

                    for (int i = 0; i < tb_len; i++)
                    {
                        this.cb_tb.Items.Add(tb_names2[i]);
                    }
                    added = true; ;
                }
            }
        }

        private void btn_nTb_Click(object sender, EventArgs e)
        {
            string tableName = cb_tbSelect1;
            //dbx.SaveDGtoXML(((xls2dg)Parent).dg_SQL,tableName+".xml");

            dbx.DGV2DB(((xls2dg)this.Parent).dg_SQL, tableName);
            MessageBox.Show("Added Successfully to your DataBase", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
