using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalAttempt_Project
{
    internal class Classes
    {
        public Classes() { }

        public Classes(int classID, string className, string classDescription, string instructor, string schedule, int capacity, string duration)
        {
            ClassID = classID;
            ClassName = className;
            ClassDescription = classDescription;
            Instructor = instructor;
            Schedule = schedule;
            Capacity = capacity;
            Duration = duration;
        }

        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public string Instructor { get; set; }
        public string Schedule { get; set; }
        public int Capacity { get; set; }
        public string Duration { get; set; }
    }
}
