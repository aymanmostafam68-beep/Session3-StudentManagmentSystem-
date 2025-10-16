using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagmentSystem
{
    internal class Instructor
    {
        public int InstructorId = 0;
        public string Name = string.Empty;
        public string Spicialization = string.Empty;

        public Instructor()
        {
            InstructorId = 0;
            Name = string.Empty;
            Spicialization = string.Empty;
        }
        public Instructor(int instructorId, string name, string spicialization)
        {
            InstructorId = instructorId;
            Name = name;
            Spicialization = spicialization;
        }

        public string PrintInstructorDetails()
        {
            return $"\n Instructor ID: {InstructorId}, Instructor: {Name}, Spicialization: {Spicialization}";
        }


    }
}
