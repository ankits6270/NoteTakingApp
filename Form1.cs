using Microsoft.Data.SqlClient;

namespace NoteTakingApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username  = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                DBConnection.open_con();
                SqlConnection conn = DBConnection.get_con();
                string query = "select name from Users where Username = @username and Password = @password";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK);
                        string name = result.ToString();
                        Notes notes = new Notes(name,username);
                        notes.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "ERROR", MessageBoxButtons.OK);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally 
            {
                DBConnection.close_con(); 
            }
        }
    }
}
