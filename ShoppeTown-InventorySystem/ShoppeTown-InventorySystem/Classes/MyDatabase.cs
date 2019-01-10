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
        /*---------- register ----------*/
        public string TestRegister(string usr, string pwd)
        {
            string checkUsers = "";
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
                    checkUsers = "EXISTING";
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
            return checkUsers;
        }
        //Insert password and username
        public string Register(string usr, string pwd)
        {
             try
            {
                con.Open();
                string SqlInsertRegister = "INSERT INTO tbl_users(" +
                    "username, password, firstName, middleName, lastName, " +
                    "userType, position, department, created_at, updated_at) " +
                    "VALUES(@username, @password, @fname, @mname, @lname, " +
                    "@usertype, @position, @department, @created_at, @updated_at);";
                MySqlCommand com = new MySqlCommand(SqlInsertRegister, con);
                com.Parameters.AddWithValue("@username", usr);
                com.Parameters.AddWithValue("@password", pwd);
                com.Parameters.AddWithValue("@fname", RegisterAutoProperty.fname);
                com.Parameters.AddWithValue("@mname", RegisterAutoProperty.mname);
                com.Parameters.AddWithValue("@lname", RegisterAutoProperty.lname);
                com.Parameters.AddWithValue("@usertype", RegisterAutoProperty.usertype);
                com.Parameters.AddWithValue("@position", RegisterAutoProperty.position);
                com.Parameters.AddWithValue("@department", RegisterAutoProperty.department);
                
                com.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                com.ExecuteNonQuery();
                //  YYYY-MM-DD HH:MM:SS
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }



    }
}
