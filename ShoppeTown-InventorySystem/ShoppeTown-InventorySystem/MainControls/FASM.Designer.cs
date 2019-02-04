namespace ShoppeTown_InventorySystem.MainControls
{
    partial class FASM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RegisterItem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(13, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(968, 390);
            this.dataGridView1.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(18, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 38);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Fixed-Asset Supply Management";
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
            this.metroPanel1.Location = new System.Drawing.Point(13, 50);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(968, 141);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(13, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 41);
            this.panel4.TabIndex = 18;
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
            // FASM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel4);
            this.Name = "FASM";
            this.Size = new System.Drawing.Size(995, 626);
            this.Load += new System.EventHandler(this.FASM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_RegisterItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
    }
}
