using System.Data.SqlClient;
using System.Data;

namespace Professional_Inventory_Manager
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            // Set up connection variables
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU Student\Desktop\Software Engineering Final\Professional Inventory Manager\Professional Inventory Manager\DB\Data.mdf"";Integrated Security=True;Connect Timeout=30;";
            SqlConnection conn;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Make SQl query and get results
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Credentials WHERE Username='" + usernameTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'", conn);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    invalidCredentialsLabel.Visible = true;
                }
                conn.Close();
            }      
        }
    }
}