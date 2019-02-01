using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppeTown_InventorySystem.Properties;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

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
        public DataGridView dgv_SearchInventory(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              "select fasm_code as 'ITEM CODE', fasm_category as 'CATEGORY', " +
              "fasm_subcat as 'SUB CAT', fasm_item as ITEM, fasm_desc as DESCRIPTION," +
              "fasm_brand as BRAND, fasm_model as MODEL from tbl_fasm " +
              "where fasm_code like '%" + search + "%' or " +
                "      fasm_category like '%" + search + "%' or " +
                "      fasm_subcat like '%" + search + "%' or " +
                "      fasm_item like '%" + search + "%' or " +
                "      fasm_desc like '%" + search + "%' or " +
                "      fasm_brand like '%" + search + "%' or " +
                "      fasm_model like '%" + search + "%';";
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }
        public DataGridView dgvFASM(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "" +
              "select * from tbl_fasm " +
              "where fasm_code like '%" + search + "%' or " +
                "      fasm_category like '%" + search + "%' or " +
                "      fasm_subcat like '%" + search + "%' or " +
                "      fasm_item like '%" + search + "%' or " +
                "      fasm_desc like '%" + search + "%' or " +
                "      fasm_brand like '%" + search + "%' or " +
                "      fasm_model like '%" + search + "%' or " +
                "      fasm_po like '%" + search + "%' or " +
                "      fasm_wpo like '%" + search + "%' or " +
                "      fasm_issued like '%" + search + "%' or " +
                "      fasm_returned like '%" + search + "%' or " +
                "      fasm_transferred like '%" + search + "%' or " +
                "      fasm_damaged like '%" + search + "%' or " +
                "      fasm_stocks like '%" + search + "%';";
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }



    }
}
