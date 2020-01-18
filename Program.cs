using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueriesConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManagement db = new DbManagement();

            while (true)
            {
                #region choice display
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add new student");
                Console.WriteLine("2.Print all students");
                Console.WriteLine("3.Add new trainer");
                Console.WriteLine("4.Print all trainers");
                Console.WriteLine("5.Add new assignment");
                Console.WriteLine("6.Print all assignments");
                Console.WriteLine("7.Add new course");
                Console.WriteLine("8.Print all courses");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Insert your choice ");
                string choice = Console.ReadLine();
                #endregion
                #region variables declaration for switch
                string firstName;
                string lastName;
                string subject;
                string assignmentTitle;
                string description;
                decimal tuitionFees;
                decimal oralMark;
                decimal totalMark;
                int courseId;
                DateTime subDateTime;
                DateTime dateOfBirth;
                string courseTitle;
                string stream;
                DateTime startDate;
                DateTime endDate;
                #endregion
                switch (choice)
                {
                    #region choice1
                    case "1":
                        Console.WriteLine("Enter student's first name ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter student's last name ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Enter student's date of birth ");
                        dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter student's tuition fees");
                        tuitionFees = Convert.ToDecimal(Console.ReadLine());

                        db.AddStudents(firstName, lastName, dateOfBirth, tuitionFees);
                        break;
                    #endregion
                    #region choice2
                    case "2":
                        List<Students> students = db.ListOfAllStudents();
                        Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-20}", "FirstName", "LastName", "DateOfBirth", "TuitionFees");
                        foreach (Students student in students)
                        {
                            Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-20}", student.FirstName, student.LastName, student.DateOfBirth, student.TuitionFees);
                        }
                        break;
                    #endregion
                    #region choice3
                    case "3":
                        Console.WriteLine("Enter trainer's first name ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter trainer's last name ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Enter subject ");
                        subject = Console.ReadLine();
                        db.AddTrainers(firstName, lastName, subject);


                        break;
                    #endregion
                    #region choice4
                    case "4":
                        List<Trainers> trainers = db.ListOfAllTrainers();
                        Console.WriteLine("{0,-30}{1,-30}{2,-10}", "FirstName", "LastName", "Subject");
                        foreach (Trainers trainer in trainers)
                        {
                            Console.WriteLine("{0,-30} {1,-30} {2,-10}", trainer.FirstName, trainer.LastName, trainer.Subject);
                        }
                        break;
                    #endregion
                    #region choice5
                    case "5":
                        Console.WriteLine("Enter course's Id");//delete if not working
                        courseId = Convert.ToInt32(Console.ReadLine());//delete if not working
                        Console.WriteLine("Enter assignment's title ");
                        assignmentTitle = Console.ReadLine();
                        Console.WriteLine("Enter description ");
                        description = Console.ReadLine();
                        Console.WriteLine("Enter oral mark ");
                        oralMark = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter total mark ");
                        totalMark = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter submission date ");
                        subDateTime = Convert.ToDateTime(Console.ReadLine());
                        db.AddAssignments(courseId, assignmentTitle, description, oralMark, totalMark, subDateTime);
                        break;
                    #endregion
                    #region choice6
                    case "6":
                        List<Assignments> assignments = db.ListOfAllAssignments();
                        Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-10} {4,-20}", "AssignmentTitle", "Description", "OralMark", "TotalMark", "SubDateTime");
                        foreach (Assignments assignment in assignments)
                        {
                            Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-10} {4,-20}", assignment.AssignmentTitle, assignment.Description, assignment.OralMark, assignment.TotalMark, assignment.SubDateTime);
                        }
                        break;
                    #endregion
                    #region choice7
                    case "7":
                        Console.WriteLine("Enter course's title ");
                        courseTitle = Console.ReadLine();
                        Console.WriteLine("Enter stream ");
                        stream = Console.ReadLine();
                        Console.WriteLine("Enter start date ");
                        startDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter end date ");
                        endDate = Convert.ToDateTime(Console.ReadLine());

                        db.AddCourses(courseTitle, stream, startDate, endDate);
                        break;
                    #endregion
                    #region choice8
                    case "8":
                        List<Courses> courses = db.ListOfAllCourses();
                        Console.WriteLine("{0,-10}{1,-30}{2,-30}{3,-20}{4,-20}", "CourseId", "CourseTitle", "Stream", "StartDate", "EndDate");
                        foreach (Courses course in courses)
                        {
                            Console.WriteLine("{0,-10}{1,-30}{2,-30}{3,-20}{4,-20}", course.CourseId, course.CourseTitle, course.Stream, course.StartDate, course.EndDate);
                        }
                        break;
                    #endregion

                    #region choice0
                    case "0":
                        Environment.Exit(0);///kleinei i efarmogi
                        break;
                        #endregion


                }
            }
        }

    }
}
