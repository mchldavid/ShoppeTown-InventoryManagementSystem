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

        //=========================register item code================
        public string[] showCategory()
        {
            string[] cont = new string[100];
            for (int x = 0; x < 100; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_category";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["category_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "select Category");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string sCode(string categoryName)
        {
            string code = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_category WHERE category_Name = @cN";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", categoryName);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    code = dr1["category_Code"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sCode");
            }
            finally
            {
                con.Close();
            }
            return code;
        }

        public string sSubCat(string cat, string code, string sub)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT a.subCategory_Number FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["subCategory_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sSubCat");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string sItem(string cat, string code, string sub)
        {
            string num = "";
            try
            {
                con.Open();
                string sql = "SELECT a.subCategory_Number FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    num = dr1["subCategory_Number"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "sSubCat");
            }
            finally
            {
                con.Close();
            }
            return num;
        }

        public string[] ShowSubCategory(string cat, string code)
        {
            string[] cont = new string[100];
            for (int x = 0; x < 100; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC ;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["subCategory_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "select SubCategory");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowItems(string cat, string code, string sub)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subcategory a, tbl_category b, tbl_item c WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["item_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowItems");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public string[] ShowBrand(string cat, string code, string sub, string item)
        {
            string[] cont = new string[200];
            for (int x = 0; x < 200; x++)
                cont[x] = "";

            int num = 0;
            try
            {
                con.Open();
                string sql = "SELECT d.brand_Name FROM tbl_subcategory a, tbl_category b, tbl_item c, tbl_brand d WHERE a.category_id = b.category_id AND a.subCategory_id = c.subCategory_id AND c.item_id = d.item_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN AND c.item_Name = @iN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", sub);
                com.Parameters.AddWithValue("@iN", item);
                com.ExecuteNonQuery();

                MySqlDataReader dr1 = com.ExecuteReader();
                while (dr1.Read())
                {
                    cont[num++] = dr1["brand_Name"].ToString();
                }
                con.Close();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "ShowBrand");
            }
            finally
            {
                con.Close();
            }
            return cont;
        }

        public void RegisterItemCode(string category, string code, string subcat, string items, string brand, string model, string description)
        {
        }

        public void InsertCategory(string category, string code)//cat1
        {
            try
            {
                con.Open();
                string sql1 = "INSERT INTO tbl_category(`category_Name`,`category_Code`) VALUES(@cN, @cC);";//inserting category
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@cN", category);
                com1.Parameters.AddWithValue("@cC", code);
                com1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "Insert Category");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertSubCategory(string cat, string code, string subName)
        {
            int count = 0;
            string id = "";
            try
            {
                //kukunin yung id ng category
                con.Open();
                string sql2 = "SELECT category_id FROM tbl_category WHERE category_Name = @cN AND category_Code = @cC;";
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@cN", cat);
                com2.Parameters.AddWithValue("@cC", code);
                com2.ExecuteNonQuery();

                MySqlDataReader dr2 = com2.ExecuteReader();
                while (dr2.Read())
                {
                    id = dr2["category_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga subcategory per category
                con.Open();
                string sql = "SELECT b.category_id FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new subcategory----->
                con.Open();
                string sql1 = "INSERT INTO tbl_subcategory(`subCategory_Name`,`subCategory_Number`, `category_id`) VALUES(@sN, @sNum, @id);";//inserting sub-category
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@sN", subName);
                com1.Parameters.AddWithValue("@sNum", ++count);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Created Successful", "Save!");
            }catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b"+ count + "a" +id, "Insert SUBCategory");
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertItemName(string cat, string code, string subName, string item)
        {
            int count = 0;
            string id = "";
            try
            {
                //kukunin yung id ng subcategory
                con.Open();
                string sql = "SELECT a.subCategory_id FROM tbl_subcategory a, tbl_category b WHERE a.category_id = b.category_id AND b.category_Name = @cN AND b.category_Code = @cC AND a.subCategory_Name = @sN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@cN", cat);
                com.Parameters.AddWithValue("@cC", code);
                com.Parameters.AddWithValue("@sN", subName);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if(dr.Read())
                {
                    id = dr["subCategory_id"].ToString();
                }
                con.Close();

                //kukunin yung bilang ng mga item per subcategory
                con.Open();
                string sql1 = "SELECT * FROM tbl_item WHERE subCategory_id = @id";
                MySqlCommand com1 = new MySqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();

                MySqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    count++;
                }
                con.Close();

                //<-----inserting ng new subcategory----->
                con.Open();
                string sql2 = "INSERT INTO tbl_item(`item_Name`,`item_Number`, `subCategory_id`) VALUES(@iN, @iNum, @id);";//inserting item-name
                MySqlCommand com2 = new MySqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@iN", item);
                com2.Parameters.AddWithValue("@iNum", ++count);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Created Successful", "Save!");
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message + "b" + count + "a" + id, "InsertItemName");
            }
            finally
            {
                con.Close();
            }
        }




        //public string selectSubCategory(string cat_id, string subcat)//subcat1
        //{
        //    string id = "";
        //    int num = 0;
        //    try
        //    {
        //        con.Open();
        //        string sql = "SELECT * FROM tbl_subcategory WHERE subCategory_Name = @sN ;";
        //        MySqlCommand com = new MySqlCommand(sql, con);
        //        com.Parameters.AddWithValue("@sN", subcat);
        //        com.ExecuteNonQuery();

        //        MySqlDataReader dr1 = com.ExecuteReader();
        //        if (dr1.Read())
        //        {
        //             id = dr1["subCategory_Num"].ToString();
        //        }
        //        con.Close();

        //        if (id == "")
        //        {
        //            con.Open();
        //            string sqll = "SELECT * FROM tbl_subcategory WHERE category_id = @id ;";
        //            MySqlCommand cyc = new MySqlCommand(sqll, con);
        //            cyc.Parameters.AddWithValue("@id", cat_id);
        //            cyc.ExecuteNonQuery();

        //            MySqlDataReader drr = cyc.ExecuteReader();
        //            if (drr.Read())
        //            {
        //                id = drr["subCategory_Num"].ToString();
        //            }
        //            con.Close();

        //            con.Open();
        //            string sql1 = "INSERT INTO tbl_subcategory(`subCategory_Name`,`subCategory_Number`,`category_id`) VALUES(@sN, @sNum, @id);";//inserting category
        //            MySqlCommand com1 = new MySqlCommand(sql1, con);
        //            com1.Parameters.AddWithValue("@sN", subcat);
        //            com1.Parameters.AddWithValue("@sNum", code);
        //            com1.Parameters.AddWithValue("@id", code);
        //            com1.ExecuteNonQuery();
        //            con.Close();

        //            con.Open();
        //            string sql2 = "SELECT * FROM tbl_category WHERE category_Name = @cN AND category_Code = @cC;";
        //            MySqlCommand com2 = new MySqlCommand(sql2, con);
        //            com2.Parameters.AddWithValue("@cN", category);
        //            com2.Parameters.AddWithValue("@cC", code);
        //            com2.ExecuteNonQuery();

        //            MySqlDataReader dr2 = com2.ExecuteReader();
        //            if (dr2.Read())
        //            {
        //                id = dr2["category_id"].ToString();
        //            }
        //            con.Close();
        //        }
        //    }
        //    catch (MySqlException sq)
        //    {
        //        MessageBox.Show(sq.Message, "select Category");
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return id;
        //}
    }
}
