using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalAttempt_Project
{
    internal class DataHandler
    {
        public DataHandler() { }

        public string connection = "Server = OREOSWITHOROS; Initial Catalog = MarineDB; Integrated Security = SSPI";
        //static string connection = "Data Source = OREOSWITHOROS; Initial Catalog = MarineDB ; Integrated Security = SSPI;";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public void Add(int classID, string className, string classDescription, string instructor, string schedule, int capacity, string duration)
        {
            string query = $"INSERT INTO Classes  VALUES ('{classID}', '{className}', '{classDescription}', '{instructor}', '{schedule}', '{capacity}', '{duration}')";
            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Details Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class Details Not Added!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void MAdd(int memberID, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string location, DateTime memberShipStartDate, DateTime memberShipEndDate)
        {
            string query = $"INSERT INTO Members  VALUES ('{memberID}', '{firstName}', '{lastName}', '{dateOfBirth}', '{gender}', '{phoneNumber}', '{location}', '{memberShipStartDate}', '{memberShipEndDate}')";
            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Details Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Member Details Not Added!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void Delete(int classID)
        {
            string query = $"DELETE FROM Classes WHERE [ClassID] = '{classID}' ";

            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class record/details deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class record/details deleted!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void MDelete(int memberID)
        {
            string query = $"DELETE FROM Members WHERE [MemberID] = '{memberID}' ";

            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member record/details deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Member record/details deleted!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void Update(int classID, string className, string classDescription, string instructor, string schedule, int capacity, string duration)
        {
            string query = $"UPDATE Classes SET [ClassID] = '{classID}', [ClassName] = '{className}'," + $"[ClassDescription] = '{classDescription}', [Instructor] = '{instructor}', [Schedule] = '{schedule}', [Capacity] = '{capacity}', [Duration] = '{duration}'";

            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Details Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class Details Not Updated Successfully!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void MUpdate(int memberID, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string location, DateTime memberShipStartDate, DateTime memberShipEndDate)
        {
            string query = $"UPDATE Members SET [MemberID] = '{memberID}', [FirstName] = '{firstName}'," + $"[LastName] = '{lastName}', [DateOfBirth] = '{dateOfBirth}', [Gender] = '{gender}', [PhoneNumber] = '{phoneNumber}', [Location] = '{location}', [MemberShipStartDate] = '{memberShipStartDate}', [MemberShipEndDate] = '{memberShipEndDate}'";

            con = new SqlConnection(connection);
            con.Open();
            cmd = new SqlCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Details Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Member Details Not Updated Successfully!" + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable Search(int classID)
        {
            string query = $"SELECT * FROM Classes WHERE [ClassID] = '{classID}'";

            con = new SqlConnection(connection);
            adapter = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable MSearch(int memberID)
        {
            string query = $"SELECT * FROM Members WHERE [MemberID] = '{memberID}'";

            con = new SqlConnection(connection);
            adapter = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
