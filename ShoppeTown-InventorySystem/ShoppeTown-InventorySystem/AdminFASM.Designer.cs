namespace ShoppeTown_InventorySystem
{
    partial class AdminFASM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFASM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlDtp = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPurchasing = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBackupAndRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserAccounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RegisterItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlDtp.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // pnlDtp
            // 
            this.pnlDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDtp.BackColor = System.Drawing.Color.Silver;
            this.pnlDtp.Controls.Add(this.lblDate);
            this.pnlDtp.Location = new System.Drawing.Point(231, 723);
            this.pnlDtp.Name = "pnlDtp";
            this.pnlDtp.Size = new System.Drawing.Size(991, 18);
            this.pnlDtp.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(752, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 24);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Items";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(245, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 41);
            this.panel4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(682, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search:";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 56);
            this.panel1.TabIndex = 8;
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
            this.pnlButtons.Controls.Add(this.btnUserAccounts);
            this.pnlButtons.Controls.Add(this.btnInventory);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Location = new System.Drawing.Point(0, 55);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(231, 686);
            this.pnlButtons.TabIndex = 9;
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnPurchasing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchasing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchasing.BorderRadius = 0;
            this.btnPurchasing.ButtonText = "Procurement";
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
            this.btnPurchasing.Text = "Procurement";
            this.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchasing.Textcolor = System.Drawing.Color.White;
            this.btnPurchasing.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnUserAccounts
            // 
            this.btnUserAccounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnUserAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserAccounts.BorderRadius = 0;
            this.btnUserAccounts.ButtonText = "User Accounts";
            this.btnUserAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAccounts.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserAccounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserAccounts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUserAccounts.Iconimage")));
            this.btnUserAccounts.Iconimage_right = null;
            this.btnUserAccounts.Iconimage_right_Selected = null;
            this.btnUserAccounts.Iconimage_Selected = null;
            this.btnUserAccounts.IconMarginLeft = 0;
            this.btnUserAccounts.IconMarginRight = 0;
            this.btnUserAccounts.IconRightVisible = true;
            this.btnUserAccounts.IconRightZoom = 0D;
            this.btnUserAccounts.IconVisible = true;
            this.btnUserAccounts.IconZoom = 90D;
            this.btnUserAccounts.IsTab = false;
            this.btnUserAccounts.Location = new System.Drawing.Point(0, 141);
            this.btnUserAccounts.Name = "btnUserAccounts";
            this.btnUserAccounts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserAccounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnUserAccounts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserAccounts.selected = false;
            this.btnUserAccounts.Size = new System.Drawing.Size(239, 48);
            this.btnUserAccounts.TabIndex = 3;
            this.btnUserAccounts.Text = "User Accounts";
            this.btnUserAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAccounts.Textcolor = System.Drawing.Color.White;
            this.btnUserAccounts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = "FASM";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventory.Iconimage")));
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 0;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 90D;
            this.btnInventory.IsTab = false;
            this.btnInventory.Location = new System.Drawing.Point(0, 94);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInventory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventory.selected = false;
            this.btnInventory.Size = new System.Drawing.Size(239, 48);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "FASM";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Textcolor = System.Drawing.Color.White;
            this.btnInventory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(245, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Fixed-Asset Supply Management";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(245, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(968, 390);
            this.dataGridView1.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.btn_RemoveItem);
            this.metroPanel1.Controls.Add(this.btn_EditItem);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.btn_RegisterItem);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(245, 103);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(968, 141);
            this.metroPanel1.TabIndex = 15;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.BackColor = System.Drawing.Color.Firebrick;
            this.btn_RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RemoveItem.Location = new System.Drawing.Point(6, 103);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(131, 32);
            this.btn_RemoveItem.TabIndex = 7;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = false;
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_EditItem.Location = new System.Drawing.Point(6, 65);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(131, 32);
            this.btn_EditItem.TabIndex = 6;
            this.btn_EditItem.Text = "Edit Item";
            this.btn_EditItem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manage Stocks";
            // 
            // btn_RegisterItem
            // 
            this.btn_RegisterItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_RegisterItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RegisterItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RegisterItem.Location = new System.Drawing.Point(6, 27);
            this.btn_RegisterItem.Name = "btn_RegisterItem";
            this.btn_RegisterItem.Size = new System.Drawing.Size(131, 32);
            this.btn_RegisterItem.TabIndex = 3;
            this.btn_RegisterItem.Text = "Register Item";
            this.btn_RegisterItem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(231, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 18);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date: 01/09/19";
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBoard.Location = new System.Drawing.Point(231, 55);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(993, 626);
            this.pnlBoard.TabIndex = 17;
            // 
            // AdminFASM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDtp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel4);
            this.Name = "AdminFASM";
            this.Load += new System.EventHandler(this.AdminFASM_Load);
            this.pnlDtp.ResumeLayout(false);
            this.pnlDtp.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlDtp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlButtons;
        public Bunifu.Framework.UI.BunifuFlatButton btnPurchasing;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogs;
        public Bunifu.Framework.UI.BunifuFlatButton btnBackupAndRestore;
        public Bunifu.Framework.UI.BunifuFlatButton btnUserAccounts;
        public Bunifu.Framework.UI.BunifuFlatButton btnInventory;
        public Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_RegisterItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlBoard;
    }
}