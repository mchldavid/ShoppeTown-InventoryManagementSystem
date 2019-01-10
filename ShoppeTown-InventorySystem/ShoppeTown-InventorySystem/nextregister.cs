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
    public partial class nextregister : MetroFramework.Forms.MetroForm
    {
        MyDatabase md = new MyDatabase();
        public nextregister()
        {
            InitializeComponent();
        }

        private void nextregister_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (md.TestRegister(txtUsername.Text, txtPassword.Text) == "EXISTING")
                {
                    MessageBox.Show("Username is already taken.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Account created successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    md.Register(txtUsername.Text, txtPassword.Text);

                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
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
    }
}
