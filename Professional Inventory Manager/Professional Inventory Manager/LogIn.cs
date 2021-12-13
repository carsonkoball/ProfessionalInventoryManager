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

        private string databasePath = string.Empty;
        private string connectionString = string.Empty;

        // take the database file path and convert it into a connection string to the database itself
        private string getConnectionString()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = """;
            connectionString = connectionString + databasePath;
            connectionString = connectionString + @""" ; Integrated Security = True; Connect Timeout = 30;";
            
            return connectionString;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (databasePath != string.Empty)
            {
                // Set up connection variables
                SqlConnection conn;
                connectionString = getConnectionString();

                using (conn = new SqlConnection(connectionString))
                {
                    invalidDatabaseLabel.Visible = false;
                    conn.Open();

                    // Make SQl query and get results
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Credentials WHERE Username='" + usernameTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'", conn);
                    DataTable dt = new DataTable(); //this is creating a virtual table  
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Main main = new Main();
                        main.connectionString = connectionString;
                        main.Show();
                    }
                    else
                    {
                        invalidCredentialsLabel.Visible = true;
                    }
                    conn.Close();
                }
            } else
            {
                invalidDatabaseLabel.Visible = true;
            } 
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes the program when "x" button is used
            Application.Exit();
        }

        private void chooseDatabaseFileButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            if (databaseFileDialog.ShowDialog() == DialogResult.OK) // Test result.
            {
                string filePath = databaseFileDialog.FileName;
                databaseTextBox.Text = filePath;
                databasePath = filePath;
            }
        }
    }
}