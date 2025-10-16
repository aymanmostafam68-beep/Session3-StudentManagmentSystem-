using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class Course
    {
        public int CourseId;
        public string Title;
        public Instructor Instructor;

        public Course()
        {
            CourseId = 0;
            Title = string.Empty;
            Instructor = new Instructor();

        }

        public Course(int courseId, string title, Instructor instructor)
        {
            CourseId = courseId;
            Title = title;
            Instructor = instructor;
        }

        public string PrintCourseDetails()
        {
            return $"\n Course ID: {CourseId}, Title: {Title}, Instructor: {Instructor.Name}";
        }
    }
}
