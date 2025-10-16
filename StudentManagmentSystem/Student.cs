using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class Student
    {
        public int StudentId;
        public string Name = string.Empty;
        public int Age;
        public List<Course> EnrolledCourses;
        static List<Student> students = new();

        public Student()
        {
            StudentId = 0;
            Name = string.Empty;
            Age = 0;
            EnrolledCourses = new List<Course>();


        }

        public Student(int studentId, string name, int age, List<Course> enrolledCourses = null)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            if (enrolledCourses == null)
            {
                enrolledCourses = new List<Course>();
            }
            EnrolledCourses = enrolledCourses;
        }

        public bool EnrollInCourse(Course course)
        {
            EnrolledCourses.Add(course);
            return true;
        }
        public string PrintStudentDetails()
        {
            string details = string.Empty;
            details =
                $"\n Student ID: {StudentId}, Name: {Name}, Age: {Age} \n";
            details += ("Enrolled Courses:");

            if (EnrolledCourses !=null)
            {
                foreach (var item in EnrolledCourses)
                {
                    details += ($"\n Course ID: {item.CourseId}, Title: {item.Title}, Instructor: {item.Instructor.Name}");
                }

            }


            return details;



        }
    }
}
