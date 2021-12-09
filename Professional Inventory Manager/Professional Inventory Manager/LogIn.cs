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
        private string getConnectionString()
        {
            string connectionString = AppDomain.CurrentDomain.BaseDirectory.ToString();
            connectionString = connectionString.Substring(0, connectionString.Length - 25);
            connectionString = connectionString + @"DB\Data.mdf";
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + connectionString + @"; Integrated Security = True; Connect Timeout = 30;";

            return connectionString;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            // Set up connection variables
            string connectionString = getConnectionString();
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

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the program when "x" button is used
            Application.Exit();
        }
    }
}