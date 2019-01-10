using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppeTown_InventorySystem.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem
{
    class MyDatabase
    {
        //connection to my database
        MySqlConnection con = new MySqlConnection("server=" + Settings.Default["Server"].ToString()
            + "; username=" + Settings.Default["UsernameDB"].ToString()
            + "; password=" + Settings.Default["PasswordDB"].ToString()
            + "; database=" + Settings.Default["DatabaseName"].ToString()
            + "; port=" + Settings.Default["Port"].ToString() + ";");

        public string TestLogin(string usr, string pwd)
        {
            string usersResult = "";
            try
            {
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE username=@u AND password=@p;";
                MySqlCommand com = new MySqlCommand(SqlSelectUsers, con);
                com.Parameters.AddWithValue("@u", usr);
                com.Parameters.AddWithValue("@p", pwd);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usersResult = "PASSED";
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return usersResult;
        }
    }
}
