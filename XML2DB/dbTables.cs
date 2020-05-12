using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace XML2DB
{
    public partial class dbTables : UserControl
    {
        public static string connString = null;
         
        Graphics gr = default(Graphics);
        Pen pen_draw = new Pen(Color.Black);
        SolidBrush sb = new SolidBrush(Color.SteelBlue);
        Connection cn;
        Cnx cnx;
        /*
         This variable for comboBox filling the comboBox
         */
        public static string[] tb_names;
        public static int tb_length=-1;
        public static bool added = false;
        public static string cb_tbSelect;
        /*
         
         */

       DB2XML dbx = new DB2XML();
     

        public dbTables(String[] tb)
        {
            InitializeComponent();
            tb_names= tb;

        }
        public dbTables(String[] tb, int length)
        {
            InitializeComponent();
            tb_names = tb;
            tb_length = length;

        }

        public dbTables()
        {
            InitializeComponent();


        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            try { 

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        // draw triangle for the Tip



        private void pn_trg_Paint_1(object sender, PaintEventArgs e)
        {

            gr = e.Graphics;
            Point[] p = new Point[3];
            p[0].X = 0;
            p[0].Y = 15;

            p[1].X = 20;
            p[1].Y = 15;

            p[2].X = 10;
            p[2].Y = 5;
            gr.DrawPolygon(this.pen_draw, p);
            gr.FillPolygon(this.sb, p);
        }

        public  void fillCB(String[] tb)
        {
            for (int i = 0; i < tb.Length; i++)
            {
                this.cb_tb.Items.Add(tb[i]);
            }

            }

        private void dbTables_Load(object sender, EventArgs e)
        {
            
           
        }

        private void dbTables_VisibleChanged(object sender, EventArgs e)
        {
           if (tb_length > -1)
            {

                if (!added)
                {

              for (int i = 0; i< tb_length; i++)
                {
                  this.cb_tb.Items.Add(tb_names[i]);
                }
                    added = true; ;
                }
            }
        }

        private void btn_nTb_Click(object sender, EventArgs e)
        {
            cb_tbSelect = cb_tb.SelectedItem.ToString();
            dbx.TableToXML(cb_tbSelect);
            ((db2dg)Parent).DG_Write(cb_tbSelect);
            ((db2dg)Parent).pn_editDG.Visible = true;
            this.Hide();
        }

    }
    }

