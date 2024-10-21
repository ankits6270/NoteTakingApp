using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Notes : Form
    {
        private string userName;
        private string userUsername;
        public Notes(string name, string username)
        {
            InitializeComponent();
            userName = name;
            userUsername = username;
            lblName.Text = $"Welcome, {userName}";
            LoadNotes();
        }
        private Dictionary<string, string> notesDictionary = new Dictionary<string, string>();
        private void LoadNotes()
        {
            try
            {
                DBConnection.open_con();
                SqlConnection conn = DBConnection.get_con();
                string query = "SELECT Title, Description FROM Notes WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userUsername);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        notesDictionary.Clear();
                        lstboxMyNotes.Items.Clear();
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string description = reader["Description"].ToString();
                            notesDictionary[title] = description;
                            lstboxMyNotes.Items.Add(title);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading notes: {ex.Message}");
            }
            finally
            {
                DBConnection.close_con();
            }
        }
        private void lstboxMyNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxMyNotes.SelectedItem != null)
            {
                string selectedTitle = lstboxMyNotes.SelectedItem.ToString();
                if (notesDictionary.ContainsKey(selectedTitle))
                {
                    rtxtNotes.Text = notesDictionary[selectedTitle];
                }
            }
        }
        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = rtxtDescription.Text;
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Both title and description are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBConnection.open_con();
                SqlConnection conn = DBConnection.get_con();
                string insertQuery = "INSERT INTO Notes (Username,Title, Description) VALUES (@username,@title, @description)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", userUsername);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note added successfully", "Success", MessageBoxButtons.OK);
                        LoadNotes();
                        txtTitle.Clear();
                        rtxtDescription.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add note", "Error", MessageBoxButtons.OK);
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();   
        }
    }
}
