using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace XML2DB
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            about ab = new about();

            if (Application.OpenForms[ab.Name] == null)
            {
                ab.Show();
            }
            else
            {
                Application.OpenForms[ab.Name].Focus();
                Application.OpenForms[ab.Name].Activate();
                Application.OpenForms[ab.Name].BringToFront();
            }
        }

        private void btn_about_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).show_db2dg();
        }

        private void btn_etd_Click(object sender, EventArgs e)
        {
            ((Main) ParentForm).show_xls2dg();
        }
    }
}