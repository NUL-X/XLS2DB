namespace XML2DB
{
    partial class ConnectionFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionFrame));
            this.btn_cn = new System.Windows.Forms.Button();
            this.cb_auth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.tb_usr = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_db = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_opt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_opt = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ip4 = new System.Windows.Forms.TextBox();
            this.tb_ip3 = new System.Windows.Forms.TextBox();
            this.tb_ip2 = new System.Windows.Forms.TextBox();
            this.tb_ip1 = new System.Windows.Forms.TextBox();
            this.nm_port = new System.Windows.Forms.NumericUpDown();
            this.tb_instance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_opt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nm_port)).BeginInit();
            this.pnl_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cn
            // 
            this.btn_cn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_cn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cn.Location = new System.Drawing.Point(357, 38);
            this.btn_cn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cn.Name = "btn_cn";
            this.btn_cn.Size = new System.Drawing.Size(138, 46);
            this.btn_cn.TabIndex = 0;
            this.btn_cn.Text = "Connect";
            this.toolTip1.SetToolTip(this.btn_cn, "Connect to database");
            this.btn_cn.UseVisualStyleBackColor = false;
            this.btn_cn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_auth
            // 
            this.cb_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cb_auth.FormattingEnabled = true;
            this.cb_auth.Items.AddRange(new object[] {"Windows Authentication", "SQLServer Authentication"});
            this.cb_auth.Location = new System.Drawing.Point(238, 46);
            this.cb_auth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_auth.Name = "cb_auth";
            this.cb_auth.Size = new System.Drawing.Size(538, 33);
            this.cb_auth.TabIndex = 1;
            this.cb_auth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(34, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 1);
            this.panel1.TabIndex = 2;
            // 
            // btn_cl
            // 
            this.btn_cl.Location = new System.Drawing.Point(502, 38);
            this.btn_cl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(138, 46);
            this.btn_cl.TabIndex = 3;
            this.btn_cl.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_cl, "Cancel");
            this.btn_cl.UseVisualStyleBackColor = true;
            this.btn_cl.Click += new System.EventHandler(this.btn_cl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Authentication:";
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Enabled = false;
            this.lbl_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_usr.Location = new System.Drawing.Point(92, 202);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(97, 22);
            this.lbl_usr.TabIndex = 5;
            this.lbl_usr.Text = "Username:";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Enabled = false;
            this.lbl_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_pwd.Location = new System.Drawing.Point(92, 270);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(94, 22);
            this.lbl_pwd.TabIndex = 6;
            this.lbl_pwd.Text = "Password:";
            // 
            // tb_usr
            // 
            this.tb_usr.Enabled = false;
            this.tb_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_usr.Location = new System.Drawing.Point(386, 202);
            this.tb_usr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_usr.Name = "tb_usr";
            this.tb_usr.Size = new System.Drawing.Size(391, 31);
            this.tb_usr.TabIndex = 7;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Enabled = false;
            this.tb_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_pwd.Location = new System.Drawing.Point(386, 259);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(391, 31);
            this.tb_pwd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "DataBase Name:";
            // 
            // tb_db
            // 
            this.tb_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_db.Location = new System.Drawing.Point(238, 122);
            this.tb_db.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_db.Name = "tb_db";
            this.tb_db.Size = new System.Drawing.Size(538, 31);
            this.tb_db.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(32, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "SQL Server";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 112);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(1, 115);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 4);
            this.panel3.TabIndex = 15;
            // 
            // btn_opt
            // 
            this.btn_opt.Location = new System.Drawing.Point(647, 38);
            this.btn_opt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_opt.Name = "btn_opt";
            this.btn_opt.Size = new System.Drawing.Size(138, 46);
            this.btn_opt.TabIndex = 16;
            this.btn_opt.Text = "Options>>";
            this.toolTip1.SetToolTip(this.btn_opt, "More Options for Remote Connection");
            this.btn_opt.UseVisualStyleBackColor = true;
            this.btn_opt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tb_db);
            this.panel4.Controls.Add(this.lbl_pwd);
            this.panel4.Controls.Add(this.cb_auth);
            this.panel4.Controls.Add(this.lbl_usr);
            this.panel4.Controls.Add(this.tb_usr);
            this.panel4.Controls.Add(this.tb_pwd);
            this.panel4.Location = new System.Drawing.Point(1, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(813, 324);
            this.panel4.TabIndex = 17;
            // 
            // pnl_opt
            // 
            this.pnl_opt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_opt.Controls.Add(this.label10);
            this.pnl_opt.Controls.Add(this.label9);
            this.pnl_opt.Controls.Add(this.label8);
            this.pnl_opt.Controls.Add(this.tb_ip4);
            this.pnl_opt.Controls.Add(this.tb_ip3);
            this.pnl_opt.Controls.Add(this.tb_ip2);
            this.pnl_opt.Controls.Add(this.tb_ip1);
            this.pnl_opt.Controls.Add(this.nm_port);
            this.pnl_opt.Controls.Add(this.tb_instance);
            this.pnl_opt.Controls.Add(this.label7);
            this.pnl_opt.Controls.Add(this.label6);
            this.pnl_opt.Controls.Add(this.label3);
            this.pnl_opt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_opt.Location = new System.Drawing.Point(35, 458);
            this.pnl_opt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_opt.Name = "pnl_opt";
            this.pnl_opt.Size = new System.Drawing.Size(751, 152);
            this.pnl_opt.TabIndex = 18;
            this.pnl_opt.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = ".";
            // 
            // tb_ip4
            // 
            this.tb_ip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_ip4.Location = new System.Drawing.Point(431, 75);
            this.tb_ip4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ip4.MaxLength = 3;
            this.tb_ip4.Name = "tb_ip4";
            this.tb_ip4.Size = new System.Drawing.Size(55, 31);
            this.tb_ip4.TabIndex = 21;
            // 
            // tb_ip3
            // 
            this.tb_ip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_ip3.Location = new System.Drawing.Point(346, 75);
            this.tb_ip3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ip3.MaxLength = 3;
            this.tb_ip3.Name = "tb_ip3";
            this.tb_ip3.Size = new System.Drawing.Size(55, 31);
            this.tb_ip3.TabIndex = 20;
            // 
            // tb_ip2
            // 
            this.tb_ip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_ip2.Location = new System.Drawing.Point(264, 75);
            this.tb_ip2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ip2.MaxLength = 3;
            this.tb_ip2.Name = "tb_ip2";
            this.tb_ip2.Size = new System.Drawing.Size(55, 31);
            this.tb_ip2.TabIndex = 19;
            this.tb_ip2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ip2_KeyPress);
            // 
            // tb_ip1
            // 
            this.tb_ip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_ip1.Location = new System.Drawing.Point(182, 75);
            this.tb_ip1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ip1.MaxLength = 3;
            this.tb_ip1.Name = "tb_ip1";
            this.tb_ip1.Size = new System.Drawing.Size(55, 31);
            this.tb_ip1.TabIndex = 18;
            this.tb_ip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nm_port
            // 
            this.nm_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nm_port.Location = new System.Drawing.Point(631, 75);
            this.nm_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nm_port.Maximum = new decimal(new int[] {65535, 0, 0, 0});
            this.nm_port.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nm_port.Name = "nm_port";
            this.nm_port.Size = new System.Drawing.Size(100, 30);
            this.nm_port.TabIndex = 17;
            this.nm_port.Value = new decimal(new int[] {1433, 0, 0, 0});
            // 
            // tb_instance
            // 
            this.tb_instance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tb_instance.Location = new System.Drawing.Point(182, 22);
            this.tb_instance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_instance.Name = "tb_instance";
            this.tb_instance.Size = new System.Drawing.Size(548, 31);
            this.tb_instance.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(507, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Server Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Server Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Instance name:";
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_cn);
            this.pnl_btn.Controls.Add(this.btn_cl);
            this.pnl_btn.Controls.Add(this.panel1);
            this.pnl_btn.Controls.Add(this.btn_opt);
            this.pnl_btn.Location = new System.Drawing.Point(1, 638);
            this.pnl_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(813, 105);
            this.pnl_btn.TabIndex = 19;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Close";
            // 
            // ConnectionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 745);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.pnl_opt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_opt.ResumeLayout(false);
            this.pnl_opt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nm_port)).EndInit();
            this.pnl_btn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.Button btn_cn;
        private System.Windows.Forms.Button btn_opt;
        private System.Windows.Forms.ComboBox cb_auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.NumericUpDown nm_port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_btn;
        private System.Windows.Forms.Panel pnl_opt;
        private System.Windows.Forms.TextBox tb_db;
        private System.Windows.Forms.TextBox tb_instance;
        private System.Windows.Forms.TextBox tb_ip1;
        private System.Windows.Forms.TextBox tb_ip2;
        private System.Windows.Forms.TextBox tb_ip3;
        private System.Windows.Forms.TextBox tb_ip4;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_usr;
        private System.Windows.Forms.ToolTip toolTip1;

        #endregion
    }
}

