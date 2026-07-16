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
    public partial class Form5 : Form
    {
        Member member = new Member();
        DataHandler handler = new DataHandler();
        Classes classes = new Classes();

        public Form5()
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
            member.MemberID = int.Parse(txtMemberID.Text.ToString());
            dgvMembers.DataSource = handler.MSearch(member.MemberID);

            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDateOfBirth.Clear();
            txtGender.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtMemberStart.Clear();
            txtMemberEnd.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            member.MemberID = int.Parse(txtMemberID.Text);
            member.FirstName = txtFirstName.Text;
            member.LastName = txtLastName.Text;
            member.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            member.Gender = txtGender.Text;
            member.PhoneNumber = txtPhoneNumber.Text;
            member.Location = txtAddress.Text;
            member.MemberShipStartDate = DateTime.Parse(txtMemberStart.Text);
            member.MemberShipEndDate = DateTime.Parse(txtMemberEnd.Text);

            handler.MUpdate(member.MemberID, member.FirstName, member.LastName, member.DateOfBirth, member.Gender, member.PhoneNumber, member.Location, member.MemberShipStartDate, member.MemberShipEndDate);

            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDateOfBirth.Clear();
            txtGender.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtMemberStart.Clear();
            txtMemberEnd.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            member.MemberID = int.Parse(txtMemberID.Text);
            handler.MDelete(member.MemberID);

            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDateOfBirth.Clear();
            txtGender.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtMemberStart.Clear();
            txtMemberEnd.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            member.MemberID = int.Parse(txtMemberID.Text);
            member.FirstName = txtFirstName.Text;
            member.LastName = txtLastName.Text;
            member.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            member.Gender = txtGender.Text;
            member.PhoneNumber = txtPhoneNumber.Text;
            member.Location = txtAddress.Text;
            member.MemberShipStartDate = DateTime.Parse(txtMemberStart.Text);
            member.MemberShipEndDate = DateTime.Parse(txtMemberEnd.Text);

            handler.MAdd(member.MemberID, member.FirstName, member.LastName, member.DateOfBirth, member.Gender, member.PhoneNumber, member.Location, member.MemberShipStartDate, member.MemberShipEndDate);

            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDateOfBirth.Clear();
            txtGender.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtMemberStart.Clear();
            txtMemberEnd.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
