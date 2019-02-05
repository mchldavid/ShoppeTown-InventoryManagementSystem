using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppeTown_InventorySystem.Properties;
using MySql.Data.MySqlClient;

namespace ShoppeTown_InventorySystem
{
    public partial class frmAdminDashboard : MetroFramework.Forms.MetroForm
    {
        MyDatabase md = new MyDatabase();
      
        string button;
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MainControls.Dashboard dash = new MainControls.Dashboard();
            pnlAdminBoard.Controls.Add(dash);
        }

        

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            button = "1";
            getBackColor(button);

            pnlAdminBoard.Controls.Clear();
            MainControls.Dashboard dash = new MainControls.Dashboard();
            pnlAdminBoard.Controls.Add(dash);
        }

       

        private void btnPurchaseRequest_Click(object sender, EventArgs e)
        {
            button = "2";
            getBackColor(button);

            pnlAdminBoard.Controls.Clear();
            MainControls.PR pr = new MainControls.PR();
            pnlAdminBoard.Controls.Add(pr);
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            button = "3";
            getBackColor(button);

            pnlAdminBoard.Controls.Clear();
            MainControls.PO po = new MainControls.PO();
            pnlAdminBoard.Controls.Add(po);

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            button = "4";
            getBackColor(button);

            pnlAdminBoard.Controls.Clear();
            MainControls.Delivery deliv = new MainControls.Delivery();
            pnlAdminBoard.Controls.Add(deliv);
        }

        private void btnFASM_Click(object sender, EventArgs e)
        {
            button = "5";
            getBackColor(button);

            pnlAdminBoard.Controls.Clear();
            MainControls.FASM fasm = new MainControls.FASM();
            pnlAdminBoard.Controls.Add(fasm);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            button = "6";
            getBackColor(button);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            button = "7";
            getBackColor(button);
        }

        public void getBackColor(string click)
        {
            if (click == "1")
            {
                btnDashboard.Normalcolor = Color.FromArgb(182, 89, 5);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "2")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(182, 89, 5);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "3")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(182, 89, 5);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "4")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(182, 89, 5);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "5")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(182, 89, 5);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "6")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(182, 89, 5);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
            else if (click == "7")
            {
                btnDashboard.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnDelivery.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(182, 89, 5);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
