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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (md.TestLogin(txtUsername.Text, txtPassword.Text) == "PASSED")
                {
                    frmAdminDashboard admin = new frmAdminDashboard();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Account Doesn't Exists!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Username is required!", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password is required!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register register = new register();
            this.Hide();
            register.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
