using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML2DB
{
    public partial class ConnectionFrame : Form
    {
        bool opt = false;
        public string connetionString = "";
        //Connection cn;
        private SqlConnection _cn;
        DataBaseToDGVUserCtrl dbt;
        xlsToDGVUserCtrl xdb;

        public ConnectionFrame()
        {
            InitializeComponent();
            pnl_btn.Location = new Point(0, 280);
            this.Height = 385;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;

            string auth = cb_auth.Text;
            string dbname = this.tb_db.Text;
            string username = this.tb_usr.Text;
            string password = this.tb_pwd.Text;

            string instance = this.tb_instance.Text;
            string port = this.nm_port.Value.ToString();
            string addr = this.tb_ip1.Text + "." + this.tb_ip1.Text + "." + this.tb_ip3.Text + "." + this.tb_ip4.Text;

            if (this.opt == false)
            {
                if (auth.Equals("Windows Authentication"))
                {
                    // is this where am I supposed to test it @Yassine-Ag ??
                    //this.connetionString = @"Data Source=. ;Initial Catalog=" + dbname + ";Integrated Security = true";
                    
                    
                    ODBConnection.connectionString = $"{dbname}:{username}:{password}";
                    _cn = ODBConnection.getConnection();
                    
                    
                    new Main();


                    string[] _tb = ODBConnection.GetAllTables();

                    dbt = new DataBaseToDGVUserCtrl(_tb, _tb.Length);
                    xdb = new xlsToDGVUserCtrl(_tb, _tb.Length);
                    dbt.Visible = true;
                    return;
                }
                else if (auth.Equals("SQLServer Authentication"))
                {
                    this.connetionString = @"Data Source=.;Initial Catalog=" + dbname + ";User ID=" + username +
                                           ";Password=" + password + "";
                }
            }
            else if (this.opt == true)
            {
                if (instance == "" || addr == "")
                {
                    MessageBox.Show("Instance Name or Machine address is still empty!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (auth.Equals("Windows Authentication"))
                    {
                        this.connetionString = @"Data Source=(" + addr + ")/" + instance + "," + port +
                                               ";Network Library=DBMSSOCN;Initial Catalog=" + dbname +
                                               ";Integrated Security = true";
                    }
                    else if (auth.Equals("SQLServer Authentication"))
                    {
                        this.connetionString = @"Data Source=(" + addr + ")/" + instance + "," + port +
                                               ";Network Library=DBMSSOCN;Initial Catalog=" + dbname + ";User ID=" +
                                               username + ";Password=" + password + "";
                    }
                }
            }


            //Connection to SQLServer

            //cn = new Connection(this.connetionString, dbname);
            //cn.OpenConection();
            Main main = new Main();


            string[] tb = ODBConnection.GetAllTables();

            dbt = new DataBaseToDGVUserCtrl(tb, tb.Length);
            xdb = new xlsToDGVUserCtrl(tb, tb.Length);


            dbt.Visible = true;
            //cn.CloseConnection();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = this.cb_auth.Text;
            if (s.Equals("SQLServer Authentication"))
            {
                this.lbl_pwd.Enabled = true;
                this.lbl_usr.Enabled = true;

                this.tb_pwd.Enabled = true;
                this.tb_usr.Enabled = true;
            }
            else
            {
                this.lbl_pwd.Enabled = false;
                this.lbl_usr.Enabled = false;

                this.tb_pwd.Enabled = false;
                this.tb_usr.Enabled = false;
            }
        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (opt == false)
            {
                this.pnl_opt.Visible = true;
                this.opt = true;
                this.Height = 503;
                //  this.pnl_opt.Height = 100;
                pnl_btn.Location = new Point(0, 400);

                this.btn_opt.Text = "Options<<";
            }
            else if (opt == true)
            {
                this.pnl_opt.Visible = false;
                this.opt = false;
                // this.pnl_opt.Height = 0;
                pnl_btn.Location = new Point(0, 280);
                this.Height = 385;


                this.btn_opt.Text = "Options>>";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_ip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_ip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_ip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}