using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalAttempt_Project
{
    internal class Member
    {
        public Member() { }

        public Member(int memberID, string firstName, string lastName, DateTime dateOfBirth, string gender, string phoneNumber, string location, DateTime memberShipStartDate, DateTime memberShipEndDate)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Location = location;
            MemberShipStartDate = memberShipStartDate;
            MemberShipEndDate = memberShipEndDate;
        }

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public DateTime MemberShipStartDate { get; set; }
        public DateTime MemberShipEndDate { get; set; }
    }
}
