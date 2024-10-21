using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text;

            // Check for required fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if fields are empty
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return; // Exit the method if passwords don't match
            }

            try
            {
                DBConnection.open_con();
                SqlConnection conn = DBConnection.get_con();

                // Check if the username already exists
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        MessageBox.Show("User already exists", "Error", MessageBoxButtons.OK);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtEmail.Clear();
                        txtName.Clear();
                        return; // Exit the method if the user already exists
                    }
                }

                // Insert new user into the database
                string insertQuery = "INSERT INTO Users (Name, Username, Password, Email) VALUES (@name, @username, @password, @email)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Use hashed passwords in production
                    cmd.Parameters.AddWithValue("@email", email);

                    int rowsAffected = cmd.ExecuteNonQuery(); // No need to convert to int here, it returns the number of rows affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK);
                        Notes notes = new Notes(name,username);
                        notes.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration unsuccessful", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.close_con(); // Ensure the connection is closed in case of success or failure
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
