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
    public partial class PR : UserControl
    {
        MyDatabase md = new MyDatabase();
        public PR()
        {
            InitializeComponent();
        }

        private void PR_Load(object sender, EventArgs e)
        {
            btnAddPR.Focus();
            dgv_PR.DataSource = md.dgv_SearchInventory("").DataSource;
        }

        private void dgv_PO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletePR.Enabled = true;
            btnEditPR.Enabled = true;
        }

        private void dgv_PO_Leave(object sender, EventArgs e)
        {
            btnDeletePR.Enabled = false;
            btnEditPR.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }
    }
}
