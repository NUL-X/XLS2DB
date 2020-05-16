using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace XML2DB
{
    partial class Main
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu1 = new XML2DB.Menu();
            this.db2dg2 = new XML2DB.DataBaseToDGV();
            this.xls2dg1 = new XML2DB.xlsToDGV();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_min = new System.Windows.Forms.PictureBox();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_min)).BeginInit();
            this.pn_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Controls.Add(this.db2dg2);
            this.panel1.Controls.Add(this.xls2dg1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(2, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 718);
            this.panel1.TabIndex = 8;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTransition1.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1603, 718);
            this.menu1.TabIndex = 0;
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // db2dg2
            // 
            this.db2dg2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTransition1.SetDecoration(this.db2dg2, BunifuAnimatorNS.DecorationType.None);
            this.db2dg2.Location = new System.Drawing.Point(-2, 0);
            this.db2dg2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.db2dg2.Name = "db2dg2";
            this.db2dg2.Size = new System.Drawing.Size(1606, 714);
            this.db2dg2.TabIndex = 1;
            this.db2dg2.Visible = false;
            // 
            // xls2dg1
            // 
            this.bunifuTransition1.SetDecoration(this.xls2dg1, BunifuAnimatorNS.DecorationType.None);
            this.xls2dg1.Location = new System.Drawing.Point(3, -2);
            this.xls2dg1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xls2dg1.Name = "xls2dg1";
            this.xls2dg1.Size = new System.Drawing.Size(1601, 716);
            this.xls2dg1.TabIndex = 5;
            // 
            // pb_close
            // 
            this.pb_close.AccessibleDescription = "Close";
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.pb_close, BunifuAnimatorNS.DecorationType.None);
            this.pb_close.Image = ((System.Drawing.Image) (resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1535, 0);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(71, 55);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Tag = "Close";
            this.toolTip1.SetToolTip(this.pb_close, "Close");
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave);
            // 
            // pb_min
            // 
            this.pb_min.AccessibleDescription = "Close";
            this.pb_min.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.pb_min, BunifuAnimatorNS.DecorationType.None);
            this.pb_min.Image = ((System.Drawing.Image) (resources.GetObject("pb_min.Image")));
            this.pb_min.Location = new System.Drawing.Point(1468, 0);
            this.pb_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_min.Name = "pb_min";
            this.pb_min.Size = new System.Drawing.Size(71, 55);
            this.pb_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_min.TabIndex = 1;
            this.pb_min.TabStop = false;
            this.pb_min.Tag = "Close";
            this.toolTip1.SetToolTip(this.pb_min, "Minimize");
            this.pb_min.Click += new System.EventHandler(this.pb_min_Click);
            this.pb_min.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter_1);
            this.pb_min.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pn_main
            // 
            this.pn_main.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_main.AutoSize = true;
            this.pn_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_main.BackColor = System.Drawing.Color.SteelBlue;
            this.pn_main.Controls.Add(this.panel2);
            this.pn_main.Controls.Add(this.label1);
            this.pn_main.Controls.Add(this.pb_min);
            this.pn_main.Controls.Add(this.pb_close);
            this.bunifuTransition1.SetDecoration(this.pn_main, BunifuAnimatorNS.DecorationType.None);
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1600, 221);
            this.pn_main.TabIndex = 7;
            this.pn_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_main_MouseDown);
            this.pn_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_main_MouseMove);
            this.pn_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_main_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(748, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 125);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 100);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(742, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "XLS2DB";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF) (resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1607, 962);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_main);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_min)).EndInit();
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private XML2DB.DataBaseToDGV db2dg2;
        private System.Windows.Forms.Label label1;
        private XML2DB.Menu menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.ToolTip toolTip1;
        private XML2DB.xlsToDGV xls2dg1;

        #endregion
    }
}