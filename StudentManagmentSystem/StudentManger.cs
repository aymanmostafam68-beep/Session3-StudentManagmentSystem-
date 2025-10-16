using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class StudentManger
    {
        public List<Student> Students ;
        public List<Course> Courses ;
        public static List<Instructor> Instructors ;

        public StudentManger()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Instructors = new List<Instructor>();


        }
        public bool AddStudent(Student student)
        {
            foreach (Student item in Students)
            {
                if (item.StudentId == student.StudentId)
                {
                    return false;
                }
            }

        

            if (student != null)
            {
                student = new Student(student.StudentId,student.Name, student.Age,student.EnrolledCourses = null );
                Students.Add(student);
                return true;

            }
            else
            {
                return false;
            }
        }
        public Student FindStudent(string query)
        {
            foreach (Student item in Students)
            {
                if (item.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || item.StudentId.ToString()==(query))
                {
                    return item;
                }
            }
            return new Student();

        }
        public List<Student> GetAllStudents()
        {
            if (Students.Count > 0)
            {
                return Students;

            }
          
             return new List<Student>();
        }

        public bool UpdateStudentInformation(int studentId, Student updatedStudent)
        {
            Student student = FindStudent(studentId.ToString());

            if (student != null && updatedStudent != null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
                student.EnrolledCourses = updatedStudent.EnrolledCourses;
                return true;
            }

            return false;
        }

        public bool DeleteStudent(int studentId)
        {
            Student student = FindStudent(studentId.ToString());
            if (student != null)
            {
                Students.Remove(student);
                return true;
            }
            return false;
        }


        public bool addInstructor(Instructor instructor)
        {
            foreach (var item in Instructors)
            {
                if (item.InstructorId== instructor.InstructorId || (item.Name == instructor.Name && item.Spicialization == instructor.Spicialization))
                {
                    return false;
                }
            }

      
                instructor = new Instructor(instructor.InstructorId , instructor.Name, instructor.Spicialization);
                Instructors.Add(instructor);
                return true;


        }

        public Instructor FindInstructor(int instructorId)
        {

            foreach (Instructor item in Instructors)
            {
                if (item.InstructorId == instructorId)
                {
                    return item;

                }
            }
            return new Instructor();

        }

        public List<Instructor> GetAllInstructors()
        {
            if (Instructors.Count>0)
            {
                return Instructors;

            }
            else
            {
                return new List<Instructor>();
            }
        }

        public bool addCourse(Course course)
        {
            foreach (var item in Courses)
            {
                if (item.CourseId == course.CourseId || (item.Title == course.Title && item.Instructor == course.Instructor))
                {
                    return false;
                }
            }
        

                course = new Course(course.CourseId, course.Title,course.Instructor);
                Courses.Add(course);
                return true;

         
        
        }

        public Course FindCourse(string query)
        {

            foreach (Course item in Courses)
            {
                if (item.Title.Contains(query, StringComparison.OrdinalIgnoreCase) || item.CourseId.ToString() == (query))
                {
                    return item;
                }
            }
            return new Course();

        }

        public List<Course> GetAllCourses()
        {
            if (Courses.Count > 0)
            {
                return Courses;

            }
            else
            {
                return new List<Course>();
            }
        }

    
        public bool CheckStudentInCourse(int studentId,int CourseId)
        {
            Student student = FindStudent(studentId.ToString());
            Course course = FindCourse(CourseId.ToString());
     
            foreach (var item in student.EnrolledCourses)
            {
                if (item.CourseId == CourseId)
                {
                    return true;
                }
            }
            return false;

        }

        public string StartList()
        {
            List<string> list = new List<string>();
            list.Add("1-  Add a new Student ");
            list.Add("2-  Add a new Instructor ");
            list.Add("3-  Add Course ");
            list.Add("4-  Enroll a Student in a Course ");
            list.Add("5-  Show all Students ");
            list.Add("6-  View all Courses ");
            list.Add("7-  View all Instructors ");
            list.Add("8-  Find a Student by Id or Name");
            list.Add("9-  Find Course by ID or Name");
            list.Add("10- Check if the student enrolled in specific course ");
            list.Add("11- Return the instructor name by course name");
            list.Add("12- Update Student Information ");
            list.Add("13- Delete Student by Id");
            list.Add("14- Exit");


            return string.Join(Environment.NewLine, list);






        }
    }
}
