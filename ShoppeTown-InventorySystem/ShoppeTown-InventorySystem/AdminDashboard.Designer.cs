namespace ShoppeTown_InventorySystem
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPurchasing = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBackupAndRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFASM = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPurchaseOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDtp = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlAdminBoard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlDtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlButtons.Controls.Add(this.btnPurchasing);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnLogs);
            this.pnlButtons.Controls.Add(this.btnBackupAndRestore);
            this.pnlButtons.Controls.Add(this.btnFASM);
            this.pnlButtons.Controls.Add(this.btnPurchaseOrder);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Location = new System.Drawing.Point(0, 55);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(231, 647);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnPurchasing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchasing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchasing.BorderRadius = 0;
            this.btnPurchasing.ButtonText = "Purchase Request";
            this.btnPurchasing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchasing.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchasing.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchasing.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPurchasing.Iconimage")));
            this.btnPurchasing.Iconimage_right = null;
            this.btnPurchasing.Iconimage_right_Selected = null;
            this.btnPurchasing.Iconimage_Selected = null;
            this.btnPurchasing.IconMarginLeft = 0;
            this.btnPurchasing.IconMarginRight = 0;
            this.btnPurchasing.IconRightVisible = true;
            this.btnPurchasing.IconRightZoom = 0D;
            this.btnPurchasing.IconVisible = true;
            this.btnPurchasing.IconZoom = 90D;
            this.btnPurchasing.IsTab = false;
            this.btnPurchasing.Location = new System.Drawing.Point(0, 47);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchasing.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnPurchasing.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchasing.selected = false;
            this.btnPurchasing.Size = new System.Drawing.Size(239, 48);
            this.btnPurchasing.TabIndex = 4;
            this.btnPurchasing.Text = "Purchase Request";
            this.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchasing.Textcolor = System.Drawing.Color.White;
            this.btnPurchasing.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasing.Click += new System.EventHandler(this.btnPurchasing_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 282);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(239, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogs.BorderRadius = 0;
            this.btnLogs.ButtonText = "Logs";
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogs.Iconimage")));
            this.btnLogs.Iconimage_right = null;
            this.btnLogs.Iconimage_right_Selected = null;
            this.btnLogs.Iconimage_Selected = null;
            this.btnLogs.IconMarginLeft = 0;
            this.btnLogs.IconMarginRight = 0;
            this.btnLogs.IconRightVisible = true;
            this.btnLogs.IconRightZoom = 0D;
            this.btnLogs.IconVisible = true;
            this.btnLogs.IconZoom = 90D;
            this.btnLogs.IsTab = false;
            this.btnLogs.Location = new System.Drawing.Point(0, 235);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnLogs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogs.selected = false;
            this.btnLogs.Size = new System.Drawing.Size(239, 48);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Textcolor = System.Drawing.Color.White;
            this.btnLogs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBackupAndRestore
            // 
            this.btnBackupAndRestore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnBackupAndRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBackupAndRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackupAndRestore.BorderRadius = 0;
            this.btnBackupAndRestore.ButtonText = "Backup And Restore";
            this.btnBackupAndRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupAndRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackupAndRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackupAndRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBackupAndRestore.Iconimage")));
            this.btnBackupAndRestore.Iconimage_right = null;
            this.btnBackupAndRestore.Iconimage_right_Selected = null;
            this.btnBackupAndRestore.Iconimage_Selected = null;
            this.btnBackupAndRestore.IconMarginLeft = 0;
            this.btnBackupAndRestore.IconMarginRight = 0;
            this.btnBackupAndRestore.IconRightVisible = true;
            this.btnBackupAndRestore.IconRightZoom = 0D;
            this.btnBackupAndRestore.IconVisible = true;
            this.btnBackupAndRestore.IconZoom = 90D;
            this.btnBackupAndRestore.IsTab = false;
            this.btnBackupAndRestore.Location = new System.Drawing.Point(0, 188);
            this.btnBackupAndRestore.Name = "btnBackupAndRestore";
            this.btnBackupAndRestore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBackupAndRestore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnBackupAndRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackupAndRestore.selected = false;
            this.btnBackupAndRestore.Size = new System.Drawing.Size(239, 48);
            this.btnBackupAndRestore.TabIndex = 3;
            this.btnBackupAndRestore.Text = "Backup And Restore";
            this.btnBackupAndRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupAndRestore.Textcolor = System.Drawing.Color.White;
            this.btnBackupAndRestore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFASM
            // 
            this.btnFASM.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnFASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFASM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFASM.BorderRadius = 0;
            this.btnFASM.ButtonText = "FASM";
            this.btnFASM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFASM.DisabledColor = System.Drawing.Color.Gray;
            this.btnFASM.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFASM.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFASM.Iconimage")));
            this.btnFASM.Iconimage_right = null;
            this.btnFASM.Iconimage_right_Selected = null;
            this.btnFASM.Iconimage_Selected = null;
            this.btnFASM.IconMarginLeft = 0;
            this.btnFASM.IconMarginRight = 0;
            this.btnFASM.IconRightVisible = true;
            this.btnFASM.IconRightZoom = 0D;
            this.btnFASM.IconVisible = true;
            this.btnFASM.IconZoom = 90D;
            this.btnFASM.IsTab = false;
            this.btnFASM.Location = new System.Drawing.Point(0, 141);
            this.btnFASM.Name = "btnFASM";
            this.btnFASM.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFASM.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnFASM.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFASM.selected = false;
            this.btnFASM.Size = new System.Drawing.Size(239, 48);
            this.btnFASM.TabIndex = 3;
            this.btnFASM.Text = "FASM";
            this.btnFASM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFASM.Textcolor = System.Drawing.Color.White;
            this.btnFASM.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFASM.Click += new System.EventHandler(this.btnFASM_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchaseOrder.BorderRadius = 0;
            this.btnPurchaseOrder.ButtonText = "Purchase Order";
            this.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnPurchaseOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPurchaseOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPurchaseOrder.Iconimage")));
            this.btnPurchaseOrder.Iconimage_right = null;
            this.btnPurchaseOrder.Iconimage_right_Selected = null;
            this.btnPurchaseOrder.Iconimage_Selected = null;
            this.btnPurchaseOrder.IconMarginLeft = 0;
            this.btnPurchaseOrder.IconMarginRight = 0;
            this.btnPurchaseOrder.IconRightVisible = true;
            this.btnPurchaseOrder.IconRightZoom = 0D;
            this.btnPurchaseOrder.IconVisible = true;
            this.btnPurchaseOrder.IconZoom = 90D;
            this.btnPurchaseOrder.IsTab = false;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(0, 94);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchaseOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnPurchaseOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPurchaseOrder.selected = false;
            this.btnPurchaseOrder.Size = new System.Drawing.Size(239, 48);
            this.btnPurchaseOrder.TabIndex = 3;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrder.Textcolor = System.Drawing.Color.White;
            this.btnPurchaseOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 90D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(239, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDtp
            // 
            this.pnlDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDtp.BackColor = System.Drawing.Color.Silver;
            this.pnlDtp.Controls.Add(this.lblDate);
            this.pnlDtp.Location = new System.Drawing.Point(231, 684);
            this.pnlDtp.Name = "pnlDtp";
            this.pnlDtp.Size = new System.Drawing.Size(975, 18);
            this.pnlDtp.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(17, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date: 01/09/19";
            // 
            // pnlAdminBoard
            // 
            this.pnlAdminBoard.BackColor = System.Drawing.Color.Green;
            this.pnlAdminBoard.Location = new System.Drawing.Point(231, 55);
            this.pnlAdminBoard.Name = "pnlAdminBoard";
            this.pnlAdminBoard.Size = new System.Drawing.Size(995, 626);
            this.pnlAdminBoard.TabIndex = 18;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.pnlAdminBoard);
            this.Controls.Add(this.pnlDtp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Name = "frmAdminDashboard";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlDtp.ResumeLayout(false);
            this.pnlDtp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlButtons;
        public Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        public Bunifu.Framework.UI.BunifuFlatButton btnBackupAndRestore;
        public Bunifu.Framework.UI.BunifuFlatButton btnFASM;
        public Bunifu.Framework.UI.BunifuFlatButton btnPurchaseOrder;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogs;
        private System.Windows.Forms.Panel pnlDtp;
        private System.Windows.Forms.Label lblDate;
        public Bunifu.Framework.UI.BunifuFlatButton btnPurchasing;
        private System.Windows.Forms.Panel pnlAdminBoard;
    }
}