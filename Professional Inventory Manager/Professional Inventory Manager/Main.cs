using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Professional_Inventory_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Item Button
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            //insert logic
            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Item]
                        ([ItemID]
                        ,[ItemName]
                        ,[ItemQuantity]
                       ,[ItemPrice]
                       ,[ItemShippingDate])
                        VALUES
                       ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                //read in table data
                LoadData();
            }
        }

        private bool IfItemExistsID(SqlConnection con, string itemID)
        {
            //checks if an item id exists in the system
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            using (con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Item] WHERE [ItemID] = '" + itemID + "'", con); //Select 1 checks if it's there or not
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool IfItemExistsName(SqlConnection con, string itemName)
        {
            //checks if an item name exists in the system
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            using (con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Item] WHERE [ItemName] = '" + itemName + "'", con); //Select 1 checks if it's there or not
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void LoadData()
        {
            //a function that reads data from the table into the grid (Grid2)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            using (con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [dbo].[Item]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item["ItemID"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item["ItemName"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item["ItemQuantity"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item["ItemPrice"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = item["ItemShippingDate"].ToString();
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the program when "x" button is used
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //loads item data into the table once main loads
            LoadData();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //double-clicking the row header will put selected item info into the text boxes
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete selected item from the table
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            using (con = new SqlConnection(connectionString))
            {
                //check if item record exists
                var sqlQuery = "";

                //delete items
                if (IfItemExistsID(con, textBox2.Text))
                {
                    con.Open();
                    //this item does exist, delete
                    sqlQuery = @"DELETE FROM [Item] WHERE [ItemID] = '" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    //this item doesn't exist, error message
                    MessageBox.Show("This item does not exist.");
                }

                //read in table data
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update or change the current item's information
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                //check if item record exists
                var sqlQuery = "";

                //update items
                if (IfItemExistsID(con, textBox2.Text))
                {
                    //this item does exist, update
                    sqlQuery = @"UPDATE [Item] SET [ItemName] = '" + textBox3.Text + "' ,[ItemQuantity] = '" + textBox4.Text + "' ,[ItemPrice] = '" + textBox5.Text + "' ,[ItemShippingDate] = '" + textBox6.Text + "' WHERE [ItemID] = '" + textBox2.Text + "'";
                }
                else
                {
                    //this item doesn't exist, insert
                    sqlQuery = @"INSERT INTO[dbo].[Item]
                    ([ItemID]
                    ,[ItemName]
                    ,[ItemQuantity]
                    ,[ItemPrice]
                    ,[ItemShippingDate])
                    VALUES
                    ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                //read in table data
                LoadData();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //shows log-in screen and closes main form
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Show();

                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search for item in the table using item name or ID
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dingo\source\repos\ProfessionalInventoryManager\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection con;
            using (con = new SqlConnection(connectionString))
            {
                //check if item record exists
                if (IfItemExistsID(con, textBox1.Text))
                {
                    con.Open();
                    //this item does exist, add to text boxes
                    textBox2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    textBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                    textBox5.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                    textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                    con.Close();
                }
//                else if (IfItemExistsName(con, textBox1.Text))
//                {
//                    con.Open();
//                    //this item does exist, add to text boxes
//                    textBox2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
//                    textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
//                    textBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
//                    textBox5.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
//                    textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
//                    con.Close();
//                }
                else
                {
                    //this item doesn't exist, error message
                    MessageBox.Show("This item does not exist.");
                }

                con.Close();
            }
        }
    }
}
