using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Professional_Inventory_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            // Set up connection variables
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU Student\Desktop\Final\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30";
            SqlConnection conn;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Make SQl query and get results
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Credentials WHERE Username='" + usernameTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // If the credentials match a row in the Credentials table, proceed to other form, otherwise show error
                if (dt.Rows[0][0].ToString() == "1")
                {
                    invalidCredentialsLabel.Visible = false;
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    invalidCredentialsLabel.Visible = true;
                }
            }
        }
    }
}
