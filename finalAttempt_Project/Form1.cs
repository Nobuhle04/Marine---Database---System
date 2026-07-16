using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace finalAttempt_Project
{
    public partial class Form1 : Form
    {
        private string usersFilePath = "users.txt";
        public Form1()
        {
            InitializeComponent();
            // Creating the users file if it doesn't exist
            if (!File.Exists(usersFilePath))
            {
                File.Create(usersFilePath).Close();
            }
            // making our containers transparent
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;

            // Styling our buttons
            btnLogin.BackColor = Color.White;
            btnLogin.ForeColor = Color.FromArgb(0, 91, 150);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnRegister.BackColor = Color.White;
            btnRegister.ForeColor = Color.FromArgb(0, 91, 150);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 1;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.FromArgb(0, 91, 150);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 1;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, this.Height),
                Color.FromArgb(0, 91, 150),    // Top color
                Color.FromArgb(127, 205, 187))) // Bottom color
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Read all lines from the file
            string[] users = File.ReadAllLines(usersFilePath);

            foreach (string user in users)
            {
                string[] parts = user.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    MessageBox.Show($"Welcome {username}!");
                    // Open main form here
                    Form3 form3 = new Form3();
                    form3.Show();
                    //MainForm mainForm = new MainForm(username);
                    //mainForm.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password. Please register if you don't have an account.");

            /*
            Form3 form3 = new Form3();
            form3.ShowDialog();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
