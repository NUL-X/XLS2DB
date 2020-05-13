namespace XML2DB
{
    partial class DataBaseToDGV
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseToDGV));
            this.tb_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dg_SQL = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_del = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_mod = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_dbTbl = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_save_xls = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_save_db = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_editDG = new System.Windows.Forms.Panel();
            this.pn_save = new System.Windows.Forms.Panel();
            this.lb_editOn = new System.Windows.Forms.Label();
            this.dbTables1 = new XML2DB.DataBaseToDGVUserCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dbTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_xls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.pn_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_search.HintForeColor = System.Drawing.Color.Empty;
            this.tb_search.HintText = "Search...";
            this.tb_search.isPassword = false;
            this.tb_search.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.tb_search.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.tb_search.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.tb_search.LineThickness = 4;
            this.tb_search.Location = new System.Drawing.Point(358, 17);
            this.tb_search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(678, 40);
            this.tb_search.TabIndex = 2;
            this.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.tb_search, "search");
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // dg_SQL
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_SQL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_SQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_SQL.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dg_SQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_SQL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_SQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_SQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_SQL.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_SQL.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_SQL.DoubleBuffered = true;
            this.dg_SQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_SQL.EnableHeadersVisualStyles = false;
            this.dg_SQL.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dg_SQL.HeaderForeColor = System.Drawing.Color.White;
            this.dg_SQL.Location = new System.Drawing.Point(58, 98);
            this.dg_SQL.Name = "dg_SQL";
            this.dg_SQL.ReadOnly = true;
            this.dg_SQL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_SQL.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_SQL.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_SQL.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_SQL.RowTemplate.Height = 45;
            this.dg_SQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_SQL.Size = new System.Drawing.Size(1279, 423);
            this.dg_SQL.TabIndex = 3;
            this.dg_SQL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SQL_CellClick);
            this.dg_SQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SQL_CellContentClick_1);
            this.dg_SQL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SQL_CellContentDoubleClick);
            this.dg_SQL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SQL_CellDoubleClick);
            this.dg_SQL.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SQL_CellLeave);
            this.dg_SQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_SQL_KeyDown);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageActive = null;
            this.btn_add.Location = new System.Drawing.Point(1362, 98);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(46, 47);
            this.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add.TabIndex = 4;
            this.btn_add.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_add, "Add Row");
            this.btn_add.Zoom = 10;
            this.btn_add.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageActive = null;
            this.btn_del.Location = new System.Drawing.Point(1362, 174);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(46, 47);
            this.btn_del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_del.TabIndex = 5;
            this.btn_del.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_del, "Remove Row");
            this.btn_del.Zoom = 10;
            this.btn_del.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_mod.Image = ((System.Drawing.Image)(resources.GetObject("btn_mod.Image")));
            this.btn_mod.ImageActive = null;
            this.btn_mod.Location = new System.Drawing.Point(1362, 252);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(46, 47);
            this.btn_mod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mod.TabIndex = 6;
            this.btn_mod.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_mod, "Edit Mode");
            this.btn_mod.Zoom = 10;
            this.btn_mod.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageActive = null;
            this.btn_save.Location = new System.Drawing.Point(1362, 474);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(46, 47);
            this.btn_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_save.TabIndex = 7;
            this.btn_save.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_save, "Save Table");
            this.btn_save.Zoom = 10;
            this.btn_save.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.AccessibleDescription = "Menu";
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(23, 17);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Tag = "Menu";
            this.toolTip1.SetToolTip(this.bunifuImageButton1, "Back to menu");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_dbTbl
            // 
            this.btn_dbTbl.AccessibleDescription = "Menu";
            this.btn_dbTbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dbTbl.Image = ((System.Drawing.Image)(resources.GetObject("btn_dbTbl.Image")));
            this.btn_dbTbl.ImageActive = null;
            this.btn_dbTbl.Location = new System.Drawing.Point(101, 17);
            this.btn_dbTbl.Name = "btn_dbTbl";
            this.btn_dbTbl.Size = new System.Drawing.Size(46, 38);
            this.btn_dbTbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dbTbl.TabIndex = 10;
            this.btn_dbTbl.TabStop = false;
            this.btn_dbTbl.Tag = "Menu";
            this.toolTip1.SetToolTip(this.btn_dbTbl, "Choose Db Table");
            this.btn_dbTbl.Zoom = 10;
            this.btn_dbTbl.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // btn_save_xls
            // 
            this.btn_save_xls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save_xls.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_xls.Image")));
            this.btn_save_xls.ImageActive = null;
            this.btn_save_xls.Location = new System.Drawing.Point(24, 9);
            this.btn_save_xls.Name = "btn_save_xls";
            this.btn_save_xls.Size = new System.Drawing.Size(35, 38);
            this.btn_save_xls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_save_xls.TabIndex = 13;
            this.btn_save_xls.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_save_xls, "Save on XLS file");
            this.btn_save_xls.Zoom = 10;
            this.btn_save_xls.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // btn_save_db
            // 
            this.btn_save_db.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save_db.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_db.Image")));
            this.btn_save_db.ImageActive = null;
            this.btn_save_db.Location = new System.Drawing.Point(24, 97);
            this.btn_save_db.Name = "btn_save_db";
            this.btn_save_db.Size = new System.Drawing.Size(35, 38);
            this.btn_save_db.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_save_db.TabIndex = 14;
            this.btn_save_db.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_save_db, "Save on Database");
            this.btn_save_db.Zoom = 10;
            this.btn_save_db.Click += new System.EventHandler(this.btn_save_db_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImageActive = null;
            this.btn_Cancel.Location = new System.Drawing.Point(1011, 24);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(25, 21);
            this.btn_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Cancel, "Clear Text");
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Zoom = 15;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(24, 53);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 38);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 15;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton2, "Save on XML file");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // pn_editDG
            // 
            this.pn_editDG.Location = new System.Drawing.Point(1343, 65);
            this.pn_editDG.Name = "pn_editDG";
            this.pn_editDG.Size = new System.Drawing.Size(82, 474);
            this.pn_editDG.TabIndex = 12;
            this.pn_editDG.Visible = false;
            this.pn_editDG.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_editDG_Paint);
            // 
            // pn_save
            // 
            this.pn_save.Controls.Add(this.bunifuImageButton2);
            this.pn_save.Controls.Add(this.btn_save_db);
            this.pn_save.Controls.Add(this.btn_save_xls);
            this.pn_save.Location = new System.Drawing.Point(1343, 328);
            this.pn_save.Name = "pn_save";
            this.pn_save.Size = new System.Drawing.Size(82, 140);
            this.pn_save.TabIndex = 0;
            this.pn_save.Visible = false;
            this.pn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_save_Paint);
            // 
            // lb_editOn
            // 
            this.lb_editOn.AutoSize = true;
            this.lb_editOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editOn.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_editOn.Location = new System.Drawing.Point(1191, 534);
            this.lb_editOn.Name = "lb_editOn";
            this.lb_editOn.Size = new System.Drawing.Size(132, 20);
            this.lb_editOn.TabIndex = 15;
            this.lb_editOn.Text = "Edit Mode is ON";
            this.lb_editOn.Visible = false;
            this.lb_editOn.ClientSizeChanged += new System.EventHandler(this.label1_ClientSizeChanged);
            this.lb_editOn.Click += new System.EventHandler(this.lb_editOn_Click);
            // 
            // dbTables1
            // 
            this.dbTables1.AutoSize = true;
            this.dbTables1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dbTables1.Location = new System.Drawing.Point(69, 65);
            this.dbTables1.Name = "dbTables1";
            this.dbTables1.Size = new System.Drawing.Size(444, 474);
            this.dbTables1.TabIndex = 11;
            this.dbTables1.Load += new System.EventHandler(this.dbTables1_Load_1);
            // 
            // DataBaseToDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lb_editOn);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pn_save);
            this.Controls.Add(this.dbTables1);
            this.Controls.Add(this.btn_dbTbl);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dg_SQL);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.pn_editDG);
            this.Name = "DataBaseToDGV";
            this.Size = new System.Drawing.Size(1425, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dbTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_xls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.pn_save.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_search;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dg_SQL;
        private Bunifu.Framework.UI.BunifuImageButton btn_add;
        private Bunifu.Framework.UI.BunifuImageButton btn_del;
        private Bunifu.Framework.UI.BunifuImageButton btn_mod;
        private Bunifu.Framework.UI.BunifuImageButton btn_save;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btn_dbTbl;
        private DataBaseToDGVUserCtrl dbTables1;
        public System.Windows.Forms.Panel pn_editDG;
        private System.Windows.Forms.Panel pn_save;
        private Bunifu.Framework.UI.BunifuImageButton btn_save_xls;
        private Bunifu.Framework.UI.BunifuImageButton btn_save_db;
        public Bunifu.Framework.UI.BunifuImageButton btn_Cancel;
        private System.Windows.Forms.Label lb_editOn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
