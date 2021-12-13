namespace Professional_Inventory_Manager
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.invalidCredentialsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseDatabaseFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.invalidDatabaseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(69, 128);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username...";
            this.usernameTextBox.Size = new System.Drawing.Size(474, 39);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(69, 224);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Password...";
            this.passwordTextBox.Size = new System.Drawing.Size(474, 39);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInButton.Location = new System.Drawing.Point(433, 420);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(111, 39);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // invalidCredentialsLabel
            // 
            this.invalidCredentialsLabel.AutoSize = true;
            this.invalidCredentialsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidCredentialsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidCredentialsLabel.Location = new System.Drawing.Point(69, 425);
            this.invalidCredentialsLabel.Name = "invalidCredentialsLabel";
            this.invalidCredentialsLabel.Size = new System.Drawing.Size(172, 28);
            this.invalidCredentialsLabel.TabIndex = 5;
            this.invalidCredentialsLabel.Text = "Invalid Credentials";
            this.invalidCredentialsLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Professional Inventory Manager";
            // 
            // databaseFileDialog
            // 
            this.databaseFileDialog.FileName = "openFileDialog1";
            this.databaseFileDialog.Filter = "Database Files|*.mdf";
            // 
            // chooseDatabaseFileButton
            // 
            this.chooseDatabaseFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseDatabaseFileButton.Location = new System.Drawing.Point(433, 329);
            this.chooseDatabaseFileButton.Name = "chooseDatabaseFileButton";
            this.chooseDatabaseFileButton.Size = new System.Drawing.Size(111, 39);
            this.chooseDatabaseFileButton.TabIndex = 7;
            this.chooseDatabaseFileButton.Text = "Upload...";
            this.chooseDatabaseFileButton.UseVisualStyleBackColor = true;
            this.chooseDatabaseFileButton.Click += new System.EventHandler(this.chooseDatabaseFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database File:";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databaseTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.databaseTextBox.Location = new System.Drawing.Point(69, 329);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.ReadOnly = true;
            this.databaseTextBox.Size = new System.Drawing.Size(358, 39);
            this.databaseTextBox.TabIndex = 9;
            this.databaseTextBox.Text = "No File Chosen...";
            // 
            // invalidDatabaseLabel
            // 
            this.invalidDatabaseLabel.AutoSize = true;
            this.invalidDatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidDatabaseLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidDatabaseLabel.Location = new System.Drawing.Point(69, 425);
            this.invalidDatabaseLabel.Name = "invalidDatabaseLabel";
            this.invalidDatabaseLabel.Size = new System.Drawing.Size(191, 28);
            this.invalidDatabaseLabel.TabIndex = 10;
            this.invalidDatabaseLabel.Text = "Invalid Database File";
            this.invalidDatabaseLabel.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 508);
            this.Controls.Add(this.invalidDatabaseLabel);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseDatabaseFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invalidCredentialsLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "LogIn";
            this.Text = "Professional Inventory Manager | Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button logInButton;
        private Label invalidCredentialsLabel;
        private Label label3;
        private OpenFileDialog databaseFileDialog;
        private Button chooseDatabaseFileButton;
        private Label label4;
        private TextBox databaseTextBox;
        private Label invalidDatabaseLabel;
    }
}