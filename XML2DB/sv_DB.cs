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
    public partial class sv_DB : UserControl
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
        public static string[] tb_names2;
        public static int tb_length = -1;
        public static bool added = false;
        public static string cb_tbSelect;
        /*
         
         */

        DB2XML dbx = new DB2XML();


        public sv_DB(String[] tb)
        {
            InitializeComponent();
            tb_names2 = tb;
        }


        public sv_DB(String[] tb, int length)
        {
            InitializeComponent();
            tb_names2 = tb;
            tb_names2 = tb;
            tb_length = length;

        }


        private void pn_trg_Paint(object sender, PaintEventArgs e)
        {


            gr = e.Graphics;
            Point[] p = new Point[3];
            p[0].X = 0;
            p[0].Y = 0;

            p[1].X = 0;
            p[1].Y = 20;

            p[2].X = 7;
            p[2].Y = 10;
            gr.DrawPolygon(this.pen_draw, p);
            gr.FillPolygon(this.sb, p);

        }
    }
}
