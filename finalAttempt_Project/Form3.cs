using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalAttempt_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(0, 91, 150);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 1;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnManageClasses.BackColor = Color.White;
            btnManageClasses.ForeColor = Color.FromArgb(0, 91, 150);
            btnManageClasses.FlatStyle = FlatStyle.Flat;
            btnManageClasses.FlatAppearance.BorderSize = 1;
            btnManageClasses.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnManageMembers.BackColor = Color.White;
            btnManageMembers.ForeColor = Color.FromArgb(0, 91, 150);
            btnManageMembers.FlatStyle = FlatStyle.Flat;
            btnManageMembers.FlatAppearance.BorderSize = 1;
            btnManageMembers.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
