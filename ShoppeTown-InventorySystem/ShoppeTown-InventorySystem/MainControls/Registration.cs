using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem.MainControls
{
    public partial class Registration : UserControl
    {
        MyDatabase md = new MyDatabase();
        public Registration()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.dgv_SearchInventory("").DataSource;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegICAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRegICDrop_Click(object sender, EventArgs e)
        {

        }

        private void btnRegICEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
