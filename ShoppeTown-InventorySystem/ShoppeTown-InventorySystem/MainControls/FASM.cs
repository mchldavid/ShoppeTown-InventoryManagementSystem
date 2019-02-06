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
    public partial class FASM : UserControl
    {
        MyDatabase md = new MyDatabase();
        public FASM()
        {
            InitializeComponent();
        }

        private void FASM_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = md.dgvFASM("").DataSource;
            dataGridView1.DataSource = md.dgvUnissued("").DataSource;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = md.dgvFASM(txtSearch.Text).DataSource;
        }
    }
}
