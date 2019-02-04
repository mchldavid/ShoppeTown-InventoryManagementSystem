using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem
{
    public partial class register : MetroFramework.Forms.MetroForm
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.BackColor = Color.Orange;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RegisterAutoProperty.fname = txtFirstName.Text;
            RegisterAutoProperty.mname = txtMiddleName.Text;
            RegisterAutoProperty.lname = txtSurname.Text;
            RegisterAutoProperty.position = txtPosition.Text;
            RegisterAutoProperty.department = txtDepartment.Text;
            RegisterAutoProperty.usertype = txtUserType.Text;

            nextregister nr = new nextregister();
            nr.Show();
            this.Hide();
        }
    }
}
