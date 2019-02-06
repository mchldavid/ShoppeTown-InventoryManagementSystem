namespace ShoppeTown_InventorySystem.MainControls
{
    partial class PR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PR));
            this.dgv_PR = new System.Windows.Forms.DataGridView();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditPR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeletePR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddPR = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PR)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PR
            // 
            this.dgv_PR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PR.Location = new System.Drawing.Point(356, 60);
            this.dgv_PR.Name = "dgv_PR";
            this.dgv_PR.Size = new System.Drawing.Size(677, 553);
            this.dgv_PR.TabIndex = 2;
            this.dgv_PR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PO_CellContentClick);
            this.dgv_PR.Leave += new System.EventHandler(this.dgv_PO_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 50D;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(311, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintText = "Search Here...";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(11, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(563, 5);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(108, 30);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.TabStop = false;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Location = new System.Drawing.Point(356, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 40);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Purchase Request";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnEditPR);
            this.groupBox1.Controls.Add(this.btnDeletePR);
            this.groupBox1.Controls.Add(this.btnAddPR);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 547);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage";
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "&Send to Purchase Order";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 50D;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(12, 76);
            this.btnSend.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(316, 39);
            this.btnSend.TabIndex = 18;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "&Send to Purchase Order";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEditPR
            // 
            this.btnEditPR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnEditPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPR.BorderRadius = 0;
            this.btnEditPR.ButtonText = "&Edit";
            this.btnEditPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPR.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditPR.Enabled = false;
            this.btnEditPR.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditPR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditPR.Iconimage")));
            this.btnEditPR.Iconimage_right = null;
            this.btnEditPR.Iconimage_right_Selected = null;
            this.btnEditPR.Iconimage_Selected = null;
            this.btnEditPR.IconMarginLeft = 0;
            this.btnEditPR.IconMarginRight = 0;
            this.btnEditPR.IconRightVisible = true;
            this.btnEditPR.IconRightZoom = 0D;
            this.btnEditPR.IconVisible = true;
            this.btnEditPR.IconZoom = 50D;
            this.btnEditPR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditPR.IsTab = false;
            this.btnEditPR.Location = new System.Drawing.Point(12, 125);
            this.btnEditPR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditPR.Name = "btnEditPR";
            this.btnEditPR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditPR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnEditPR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditPR.selected = false;
            this.btnEditPR.Size = new System.Drawing.Size(316, 39);
            this.btnEditPR.TabIndex = 15;
            this.btnEditPR.TabStop = false;
            this.btnEditPR.Text = "&Edit";
            this.btnEditPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPR.Textcolor = System.Drawing.Color.White;
            this.btnEditPR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDeletePR
            // 
            this.btnDeletePR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnDeletePR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDeletePR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePR.BorderRadius = 0;
            this.btnDeletePR.ButtonText = "&Delete";
            this.btnDeletePR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePR.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletePR.Enabled = false;
            this.btnDeletePR.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletePR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeletePR.Iconimage")));
            this.btnDeletePR.Iconimage_right = null;
            this.btnDeletePR.Iconimage_right_Selected = null;
            this.btnDeletePR.Iconimage_Selected = null;
            this.btnDeletePR.IconMarginLeft = 0;
            this.btnDeletePR.IconMarginRight = 0;
            this.btnDeletePR.IconRightVisible = true;
            this.btnDeletePR.IconRightZoom = 0D;
            this.btnDeletePR.IconVisible = true;
            this.btnDeletePR.IconZoom = 50D;
            this.btnDeletePR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletePR.IsTab = false;
            this.btnDeletePR.Location = new System.Drawing.Point(12, 173);
            this.btnDeletePR.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnDeletePR.Name = "btnDeletePR";
            this.btnDeletePR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDeletePR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnDeletePR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletePR.selected = false;
            this.btnDeletePR.Size = new System.Drawing.Size(316, 39);
            this.btnDeletePR.TabIndex = 16;
            this.btnDeletePR.TabStop = false;
            this.btnDeletePR.Text = "&Delete";
            this.btnDeletePR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletePR.Textcolor = System.Drawing.Color.White;
            this.btnDeletePR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddPR
            // 
            this.btnAddPR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnAddPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPR.BorderRadius = 0;
            this.btnAddPR.ButtonText = "&Add Purchase Request";
            this.btnAddPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPR.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPR.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPR.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPR.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPR.Iconimage")));
            this.btnAddPR.Iconimage_right = null;
            this.btnAddPR.Iconimage_right_Selected = null;
            this.btnAddPR.Iconimage_Selected = null;
            this.btnAddPR.IconMarginLeft = 0;
            this.btnAddPR.IconMarginRight = 0;
            this.btnAddPR.IconRightVisible = true;
            this.btnAddPR.IconRightZoom = 0D;
            this.btnAddPR.IconVisible = true;
            this.btnAddPR.IconZoom = 50D;
            this.btnAddPR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPR.IsTab = false;
            this.btnAddPR.Location = new System.Drawing.Point(12, 25);
            this.btnAddPR.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.btnAddPR.Name = "btnAddPR";
            this.btnAddPR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddPR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnAddPR.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPR.selected = false;
            this.btnAddPR.Size = new System.Drawing.Size(316, 39);
            this.btnAddPR.TabIndex = 17;
            this.btnAddPR.TabStop = false;
            this.btnAddPR.Text = "&Add Purchase Request";
            this.btnAddPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPR.Textcolor = System.Drawing.Color.White;
            this.btnAddPR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_PR);
            this.Controls.Add(this.groupBox1);
            this.Name = "PR";
            this.Size = new System.Drawing.Size(1045, 626);
            this.Load += new System.EventHandler(this.PR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PR;
        public Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddPR;
        public Bunifu.Framework.UI.BunifuFlatButton btnDeletePR;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditPR;
        public Bunifu.Framework.UI.BunifuFlatButton btnSend;
    }
}
