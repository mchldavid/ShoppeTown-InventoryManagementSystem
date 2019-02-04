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
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MainControls.Dashboard dash = new MainControls.Dashboard();
            pnlAdminBoard.Controls.Add(dash);
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            pnlAdminBoard.Controls.Clear();
            MainControls.PO po = new MainControls.PO();
            pnlAdminBoard.Controls.Add(po);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlAdminBoard.Controls.Clear();
            MainControls.Dashboard dash = new MainControls.Dashboard();
            pnlAdminBoard.Controls.Add(dash);
        }

        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            pnlAdminBoard.Controls.Clear();
            MainControls.PR pr = new MainControls.PR();
            pnlAdminBoard.Controls.Add(pr);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnFASM_Click(object sender, EventArgs e)
        {
            pnlAdminBoard.Controls.Clear();
            MainControls.FASM fasm = new MainControls.FASM();
            pnlAdminBoard.Controls.Add(fasm);
        }
    }
}
