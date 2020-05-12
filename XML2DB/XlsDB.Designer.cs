namespace XML2DB
{
    partial class XlsDB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XlsDB));
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_nTb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cb_tb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cnx = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(4, 287);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(420, 25);
            this.bunifuSeparator2.TabIndex = 21;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btn_nTb
            // 
            this.btn_nTb.ActiveBorderThickness = 1;
            this.btn_nTb.ActiveCornerRadius = 20;
            this.btn_nTb.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btn_nTb.ActiveForecolor = System.Drawing.Color.White;
            this.btn_nTb.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_nTb.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nTb.BackgroundImage")));
            this.btn_nTb.ButtonText = "Save";
            this.btn_nTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nTb.ForeColor = System.Drawing.Color.White;
            this.btn_nTb.IdleBorderThickness = 1;
            this.btn_nTb.IdleCornerRadius = 20;
            this.btn_nTb.IdleFillColor = System.Drawing.Color.White;
            this.btn_nTb.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btn_nTb.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn_nTb.Location = new System.Drawing.Point(136, 335);
            this.btn_nTb.Margin = new System.Windows.Forms.Padding(5);
            this.btn_nTb.Name = "btn_nTb";
            this.btn_nTb.Size = new System.Drawing.Size(157, 48);
            this.btn_nTb.TabIndex = 20;
            this.btn_nTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nTb.Click += new System.EventHandler(this.btn_nTb_Click);
            // 
            // cb_tb
            // 
            this.cb_tb.AllowDrop = true;
            this.cb_tb.BackColor = System.Drawing.Color.SteelBlue;
            this.cb_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tb.ForeColor = System.Drawing.Color.White;
            this.cb_tb.FormattingEnabled = true;
            this.cb_tb.Location = new System.Drawing.Point(40, 213);
            this.cb_tb.Name = "cb_tb";
            this.cb_tb.Size = new System.Drawing.Size(351, 36);
            this.cb_tb.TabIndex = 19;
            this.cb_tb.VisibleChanged += new System.EventHandler(this.cb_tb_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "2. Choose Table:";
            // 
            // btn_cnx
            // 
            this.btn_cnx.ActiveBorderThickness = 1;
            this.btn_cnx.ActiveCornerRadius = 20;
            this.btn_cnx.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btn_cnx.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cnx.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_cnx.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cnx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cnx.BackgroundImage")));
            this.btn_cnx.ButtonText = "Connect";
            this.btn_cnx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cnx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnx.ForeColor = System.Drawing.Color.White;
            this.btn_cnx.IdleBorderThickness = 1;
            this.btn_cnx.IdleCornerRadius = 20;
            this.btn_cnx.IdleFillColor = System.Drawing.Color.White;
            this.btn_cnx.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btn_cnx.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn_cnx.Location = new System.Drawing.Point(234, 36);
            this.btn_cnx.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cnx.Name = "btn_cnx";
            this.btn_cnx.Size = new System.Drawing.Size(157, 48);
            this.btn_cnx.TabIndex = 16;
            this.btn_cnx.Tag = "";
            this.btn_cnx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cnx.Click += new System.EventHandler(this.btn_cnx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "1. Connect to DB:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 104);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(420, 25);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // XlsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.btn_nTb);
            this.Controls.Add(this.cb_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cnx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "XlsDB";
            this.Size = new System.Drawing.Size(424, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_nTb;
        public System.Windows.Forms.ComboBox cb_tb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cnx;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
