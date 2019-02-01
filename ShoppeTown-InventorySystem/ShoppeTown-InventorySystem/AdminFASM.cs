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
    public partial class AdminFASM : MetroFramework.Forms.MetroForm
    {
        MyDatabase md = new MyDatabase();
        
        public AdminFASM()
        {
            InitializeComponent();
        }

        private void AdminFASM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.dgvFASM("").DataSource; 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmDash = new frmAdminDashboard();
            frmDash.Show();
            this.Hide();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.dgvFASM(txtSearch.Text).DataSource;
        }
    }
}
