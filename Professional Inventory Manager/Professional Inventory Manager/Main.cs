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
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Item]
                ([ItemID]
                ,[ItemName]
                ,[ItemQuantity]
                ,[ItemPrice])
                VALUES
                ('" + textBox2.Text +"','"+ textBox3.Text +"','"+ textBox4.Text+ "','"+ textBox5.Text +"')", con);
                cmd.ExecuteNonQuery();

                con.Close();

            }
        }

        //closes the program when "x" button is used
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
