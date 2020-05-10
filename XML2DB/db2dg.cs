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

namespace XML2DB
{
    public partial class db2dg : UserControl
    {
        public bool dbTb = false;
        public db2dg()
        {
            InitializeComponent();
            this.dbTables1.Hide();
        }


        //[DllImport("user32.dll")]
        //static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        //private const Int32 CB_SETITEMHEIGHT = 0x153;

        //private void SetComboBoxHeight(IntPtr comboBoxHandle, Int32 comboBoxDesiredHeight)
        //{
        //    SendMessage(comboBoxHandle, CB_SETITEMHEIGHT, -1, comboBoxDesiredHeight);
        //}


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
                this.dbTb = true ;
            }
        }

        public void DG_Write(String tbName)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"" + tbName + ".xml");
            this.dg_SQL.DataSource = dataSet.Tables[0];
        }
    }
}
