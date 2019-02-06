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
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.dgv_SearchInventory("").DataSource;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.dgv_SearchInventory(textBox1.Text).DataSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AdminFASM frmFASM = new AdminFASM();
            frmFASM.Show();
            this.Hide();
        }

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            ItemCode_control item = new ItemCode_control();

            pnlBoard.Controls.Clear();
            pnlBoard.Controls.Add(item);
        }
    }
}
