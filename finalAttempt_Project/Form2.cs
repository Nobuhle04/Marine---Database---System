using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalAttempt_Project
{
    public partial class Form2 : Form
    {
        private string usersFilePath = "users.txt";
        public Form2()
        {
            InitializeComponent();

            btnRRegister.BackColor = Color.White;
            btnRRegister.ForeColor = Color.FromArgb(0, 91, 150);
            btnRRegister.FlatStyle = FlatStyle.Flat;
            btnRRegister.FlatAppearance.BorderSize = 1;
            btnRRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Check if user already exists
            if (File.Exists(usersFilePath))
            {
                string[] users = File.ReadAllLines(usersFilePath);
                foreach (string user in users)
                {
                    string[] parts = user.Split(',');
                    if (parts.Length > 0 && parts[0] == username)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }
                }
            }

            // Save the new user
            using (StreamWriter sw = File.AppendText(usersFilePath))
            {
                sw.WriteLine($"{username},{password}");
            }

            MessageBox.Show("Registration successful! You can now login.");
            this.Close();
        }
    }
}

