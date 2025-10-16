namespace StudentManagmentSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            StudentManger studentManger = new StudentManger();
            bool exit = true;
            do
            {
                Console.WriteLine("-----------------------------------");

                Console.WriteLine(studentManger.StartList());
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Add Student");
                        Console.Write("Enter Student ID: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Student Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        //Console.Write("Enter Student Course Id: ");

                        ////int CourseID = Convert.ToInt32(Console.ReadLine());

                        ////Course course1 = studentManger.FindCourse(CourseID);
                        Student student1 = new Student(studentId, name, age, new List<Course> { null });
                        if (studentManger.AddStudent(student1))
                        {
                            Console.WriteLine("the student has been added successfully ");
                            Console.WriteLine(student1.PrintStudentDetails());
                        }
                        else
                        {
                            Console.WriteLine("an error has been occurred,be sure the ID is not exists");
                        }
                ;
                        Console.WriteLine("-----------------------------------");

                        break;

                    case 2:

                        Console.WriteLine("Add a new Instructor ");
                        Console.Write("Enter Instructor ID: ");
                        int InstId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Instructor Name: ");
                        string InstName = Console.ReadLine();
                        Console.Write("Enter Instructor Specialization: ");
                        string specialization = Console.ReadLine();
                        Instructor instructor1 = new Instructor(InstId, InstName, specialization);
                        if (studentManger.addInstructor(instructor1))
                        {
                            Console.WriteLine("the instructor has been added successfully ");
                            Console.WriteLine(instructor1.PrintInstructorDetails());
                        }
                        else
                        {
                            Console.WriteLine("an error has been occurred, be sure the ID is not exists");
                        }
                        Console.WriteLine("-----------------------------------");


                        break;


                    case 3:
                        Console.WriteLine("Add a new Course ");
                        Console.Write("Enter Course ID: ");
                        int courseId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Course Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Instructor ID: ");
                        int instructorId = Convert.ToInt32(Console.ReadLine());
                        Instructor instructor = studentManger.FindInstructor(instructorId);
                        if (instructor.InstructorId == 0)
                        {
                            Console.WriteLine("Instructor not found.");
                            break;
                        }
                        Course course = new Course(courseId, title, instructor);
                        if (studentManger.addCourse(course))
                        {
                            Console.WriteLine("the course has been added successfully ");
                            Console.WriteLine(course.PrintCourseDetails());
                        }
                        else
                        {
                            Console.WriteLine("an error has been occurred ");
                        }
                        Console.WriteLine("-----------------------------------");

                        break;




                    case 4:

                        Console.WriteLine("Enroll a Student in a Course");
                        Console.Write("Enter Student ID: ");
                        int stuId = Convert.ToInt32(Console.ReadLine());
                        Student student = studentManger.FindStudent(stuId.ToString());
                        Console.Write("Enter Course ID: ");
                        int courId = Convert.ToInt32(Console.ReadLine());
                        Course course2 = studentManger.FindCourse(courId.ToString());
                        if (course2.CourseId == 0)
                        {
                            Console.WriteLine("Student or Course not found.");
                            break;
                        }
                        student.EnrollInCourse(course2);
                        Console.WriteLine("\n the student has been enrolled in the course successfully ");
                        Console.WriteLine(student.PrintStudentDetails());

                        Console.WriteLine("-----------------------------------");

                        break;

                    case 5:
                        Console.WriteLine("View all Students");
                        List<Student> students = studentManger.GetAllStudents();
                        foreach (var item in students)
                        {
                            Console.WriteLine(item.PrintStudentDetails());
                        }
                        Console.WriteLine("-----------------------------------");

                        break;


                    case 6:
                        Console.WriteLine("Show all Courses");
                        List<Course> courses = studentManger.GetAllCourses();
                        foreach (var item in courses)
                        {
                            Console.WriteLine(item.PrintCourseDetails());
                        }
                        Console.WriteLine("-----------------------------------");

                        break;



                    case 7:
                        Console.WriteLine("View all Instructors");
                        List<Instructor> instructors = studentManger.GetAllInstructors();
                        foreach (var item in instructors)
                        {
                            Console.WriteLine(item.PrintInstructorDetails());
                        }
                        Console.WriteLine("-----------------------------------");

                        break;


                    case 8:
                        Console.WriteLine("Search for a Student by ID or name");
                        Console.Write("Enter Student ID Or Name: ");
                        string Query = Console.ReadLine();
                        Student findStudent = studentManger.FindStudent(Query.ToString());
                        Console.WriteLine(findStudent.PrintStudentDetails());
                        break;

                    case 9:
                        Console.WriteLine("Search for a Course by ID or name");
                        Console.Write("Enter Course ID Or Title: ");
                        string CQuery = Console.ReadLine();
                        Course findCourse = studentManger.FindCourse(CQuery.ToString());
                        Console.WriteLine(findCourse.PrintCourseDetails());
                        Console.WriteLine("-----------------------------------");
                        break;

                    case 10:
                        Console.WriteLine("Check if the student enrolled in specific course");
                        Console.Write("Enter Student ID: ");
                        int sId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int cId = Convert.ToInt32(Console.ReadLine());
                        if (studentManger.CheckStudentInCourse(sId, cId))
                        {
                            Console.WriteLine("The student is enrolled in the course.");
                        }
                        else
                        {
                            Console.WriteLine("The student is not enrolled in the course.");
                        }
                        Console.WriteLine("-----------------------------------");
                        break;

                    case 11:
                        Console.WriteLine("Return the instructor name by course name");
                        Console.Write("Enter the Course name: ");
                        string courseName = Console.ReadLine();
                        Course course1 = studentManger.FindCourse(courseName);
                        Console.WriteLine($"the instructor name is : {course1.Instructor.Name}  ID : {course1.Instructor.InstructorId} ");
                        Console.WriteLine("-----------------------------------");
                        break;

                    case 12:
                        Console.WriteLine("Update Student Information");
                        Console.Write("Enter Student ID to update: ");
                        int updateStudentId = Convert.ToInt32(Console.ReadLine());
                        Student OldData = studentManger.FindStudent(updateStudentId.ToString());
                        Console.WriteLine(OldData.PrintStudentDetails());

                        Console.Write("Enter New Student Name: ");
                        OldData.Name = Console.ReadLine();
                        Console.Write("Enter New Student Age: ");
                        OldData.Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Student Course Id: ");
                        int NewCourseID = Convert.ToInt32(Console.ReadLine());
                        Course Newcourse = studentManger.FindCourse(NewCourseID.ToString());
                        OldData.EnrolledCourses = new List<Course> { Newcourse };
                        studentManger.UpdateStudentInformation(updateStudentId, OldData);
                        break;

                    case 13:
                        Console.WriteLine("Delete a Student by ID");
                        Console.Write("Enter Student ID to delete: ");
                        int deleteStudentId = Convert.ToInt32(Console.ReadLine());
                        if (studentManger.DeleteStudent(deleteStudentId))
                        {
                            Console.WriteLine("the student has been deleted successfully ");
                        }
                        else
                        {
                            Console.WriteLine("an error has been occurred ");
                        }
                        break;

                        case 14:
                        exit = false;
                        Console.WriteLine("Thanks,...");
                        break;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

            } while (exit);
            ///////////////////////////////////////////////////////////////////////////
            ///














            //Instructor instructor = new Instructor(instructorId: 1, name: "Dr.Mohamed", spicialization: "Backned.Net");
            //Instructor instructor2 = new Instructor(2, "Dr.Ayman", "C#");
            //Instructor instructor3 = new Instructor(3, "Dr.Ahmed", "C++");
            //Instructor instructor4 = new Instructor(4, "Dr.Ali", "java");

            //studentManger.addInstructor(instructor);
            //studentManger.addInstructor(instructor2);
            //studentManger.addInstructor(instructor3);
            //studentManger.addInstructor(instructor4);

            //List<Instructor> list = studentManger.GetAllInstructors();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.PrintInstructorDetails());
            //}
            /////////////////////////////////////////////////////////////////////////////

            //Course course = new Course(1, "BackEnd", studentManger.FindInstructor(1));
            //Course course2 = new Course(2, "C#", studentManger.FindInstructor(2));
            //Course course3 = new Course(3, "C++", studentManger.FindInstructor(3));
            //Course course4 = new Course(4, "Java", studentManger.FindInstructor(4));

            //studentManger.addCourse(course);
            //studentManger.addCourse(course2);
            //studentManger.addCourse(course3);
            //studentManger.addCourse(course4);
            //List<Course> courses = studentManger.GetAllCourses();
            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item.PrintCourseDetails());
            //}

            //Course FindCourse = studentManger.FindCourse(4);
            //Console.WriteLine($"ID: {FindCourse.CourseId} Title: {FindCourse.Title} Instructor: {FindCourse.Instructor.Name}");

            //Console.WriteLine("----------------");
            ////////////////////////////////////////////////////////////////////////////
            ////Student student = new Student(studentId: 1, name: "Ali", age: 30, enrolledCourses: new List<Course> { studentManger.FindCourse(4), studentManger.FindCourse(1) });
            ////studentManger.AddStudent(student);
            ////Student findStudent = studentManger.FindStudent(studentId: 1);

            ////Console.WriteLine($"ID: {findStudent.StudentId} Name: {findStudent.Name} Age: {findStudent.Age}");


            ///////////////////////////////////////////////////////////////////////////////





        }
    }
}
