﻿
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Together_Culture__Dream_Team_.Front_End.Src.Screens
{
    public partial class Log_in : Form
    {
        //amend this connectionString if you want to connect to the main DB
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\mysza\source\repos\Dream-Team02\12\Together Culture (Dream Team)\Database\db_TogetherCulture.mdf"";Integrated Security=True";

        public Log_in()
        {
            InitializeComponent();
        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            // Check if the email and password fields are not empty
            bool isEmailEntered = !string.IsNullOrWhiteSpace(txtEmail.Text);
            bool isPasswordEntered = !string.IsNullOrWhiteSpace(txtPassword2.Text);

            if (isEmailEntered && isPasswordEntered)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(
                            "SELECT COUNT(*) FROM [user] WHERE email = @Email AND password = @Password",
                            connection
                        );

                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@password", txtPassword2.Text);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigate to the next form or main application window
                            Profile profile = new Profile();
                            profile.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string missingFields = "Please fill in the following fields:\n";
                if (!isEmailEntered) missingFields += "- Email\n";
                if (!isPasswordEntered) missingFields += "- Password\n";

                MessageBox.Show(missingFields, "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSignUp_click(object sender, EventArgs e)
        {
            Sign_up sign_Up = new Sign_up();

            sign_Up.Show();

            this.Close();
        }
        private void Log_in_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
