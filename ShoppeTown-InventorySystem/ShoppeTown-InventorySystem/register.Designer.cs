namespace ShoppeTown_InventorySystem
{
    partial class register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "CREATE ACCOUNT";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(10, 539);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(127)))), ((int)(((byte)(12)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(332, 51);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "CREATE ACCOUNT";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.HintText = "First name";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.txtFirstName.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.txtFirstName.LineThickness = 3;
            this.txtFirstName.Location = new System.Drawing.Point(24, 99);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(306, 44);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Text = "Username";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 600);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
    }
}