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
    public partial class Form4 : Form
    {
        Member member = new Member();
        DataHandler handler = new DataHandler();
        Classes classes = new Classes();

        public Form4()
        {
            InitializeComponent();

            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.FromArgb(0, 91, 150);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.FromArgb(0, 91, 150);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 1;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.FromArgb(0, 91, 150);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = Color.FromArgb(0, 91, 150);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 1;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);

            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.FromArgb(0, 91, 150);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 1;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0, 91, 150);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            classes.ClassID = Convert.ToInt32(txtTrainingID.Text);
            dgvTrainingClasses.DataSource = handler.Search(classes.ClassID);

            txtTrainingID.Clear();
            txtTrainingName.Clear();
            txtDescription.Clear();
            txtInstructor.Clear();
            txtSchedule.Clear();
            txtCapacity.Clear();
            txtDuration.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            classes.ClassID = int.Parse(txtTrainingID.Text);
            classes.ClassName = txtTrainingName.Text;
            classes.ClassDescription = txtDescription.Text;
            classes.Instructor = txtInstructor.Text;
            classes.Schedule = txtSchedule.Text;
            classes.Capacity = int.Parse(txtCapacity.Text);
            classes.Duration = txtDuration.Text;

            handler.Update(classes.ClassID, classes.ClassName, classes.ClassDescription, classes.Instructor, classes.Schedule, classes.Capacity, classes.Duration);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            classes.ClassID = int.Parse(txtTrainingID.Text);
            handler.Delete(classes.ClassID);

            txtTrainingID.Clear();
            txtTrainingName.Clear();
            txtDescription.Clear();
            txtInstructor.Clear();
            txtSchedule.Clear();
            txtCapacity.Clear();
            txtDuration.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            classes.ClassID = int.Parse(txtTrainingID.Text);
            classes.ClassName = txtTrainingName.Text;
            classes.ClassDescription = txtDescription.Text;
            classes.Instructor = txtInstructor.Text;
            classes.Schedule = txtSchedule.Text;
            classes.Capacity = int.Parse(txtCapacity.Text);
            classes.Duration = txtDuration.Text;

            handler.Add(classes.ClassID, classes.ClassName, classes.ClassDescription, classes.Instructor, classes.Schedule, classes.Capacity, classes.Duration);

            txtTrainingID.Clear();
            txtTrainingName.Clear();
            txtDescription.Clear();
            txtInstructor.Clear();
            txtSchedule.Clear();
            txtCapacity.Clear();
            txtDuration.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
