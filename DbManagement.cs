using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
namespace SQLQueriesConsoleApplication
{
    class DbManagement
    {
        private string connection_string = @"Data Source=LAPTOP-9MK2NJAH\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddStudents(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Students (FirstName,LastName,DateOfbirth,TuitionFees) Values(@firstName,@lastName,@dateOfBirth,@tuitionFees)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@firstName", firstName));
                    cmd.Parameters.Add(new SqlParameter("@lastName", lastName));
                    cmd.Parameters.Add(new SqlParameter("@dateOfBirth", dateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@tuitionFees", tuitionFees));

                    cmd.ExecuteNonQuery();
                }




            }
        }

        public List<Students> ListOfAllStudents()
        {
            List<Students> students = new List<Students>();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From Students", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            students.Add(new Students()
                            {
                                StudentId = (int)reader["StudentId"],///pos diasfalizo integrity id;
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                TuitionFees = (decimal)reader["TuitionFees"]

                            });
                    }
                }



            }
            return students;

        }

        public void AddTrainers(string firstName, string lastName, string subject)
        {
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Trainers(FirstName,LastName,Subject) Values(@firstName,@lastName,@subject)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@firstName", firstName));
                    cmd.Parameters.Add(new SqlParameter("@lastName", lastName));
                    cmd.Parameters.Add(new SqlParameter("@subject", subject));
                    cmd.ExecuteNonQuery();
                }

            }

        }

        public List<Trainers> ListOfAllTrainers()
        {
            List<Trainers> trainers = new List<Trainers>();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From Trainers", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            trainers.Add(new Trainers()
                            {
                                TrainerId = (int)reader["TrainerId"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Subject = (string)reader["Subject"]
                            });
                    }
                }
            }
            return trainers;

        }

        public void AddAssignments(int courseId, string assignmentTitle, string description, decimal oralMark, decimal totalMark, DateTime subDateTime)
        {
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Assignments (CourseId, AssignmentTitle, Description, OralMark, TotalMark, SubDateTime) Values(@courseId, @assignmentTitle, @description, @oralMark, @totalMark, @subDateTime)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@courseId", courseId));//delete if not working
                    cmd.Parameters.Add(new SqlParameter("@assignmentTitle", assignmentTitle));
                    cmd.Parameters.Add(new SqlParameter("@description", description));
                    cmd.Parameters.Add(new SqlParameter("@oralMark", oralMark));
                    cmd.Parameters.Add(new SqlParameter("@totalMark", totalMark));
                    cmd.Parameters.Add(new SqlParameter("@subDateTime", subDateTime));

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public List<Assignments> ListOfAllAssignments()
        {
            List<Assignments> assignments = new List<Assignments>();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From Assignments", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            assignments.Add(new Assignments()
                            {
                                CourseId = (int)reader["CourseId"],
                                AssignmentId = (int)reader["AssignmentId"],
                                AssignmentTitle = (string)reader["AssignmentTitle"],
                                Description = (string)reader["Description"],
                                OralMark = (decimal)reader["OralMark"],
                                TotalMark = (decimal)reader["TotalMark"],
                                SubDateTime = (DateTime)reader["SubDateTime"]

                            });

                    }

                }
            }
            return assignments;
        }

        public void AddCourses(string courseTitle, string stream, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Courses (CourseTitle, Stream, StartDate, EndDate) Values(@courseTitle, @stream, @startDate, @endDate)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@courseTitle", courseTitle));
                    cmd.Parameters.Add(new SqlParameter("@stream", stream));
                    cmd.Parameters.Add(new SqlParameter("@startDate", startDate));
                    cmd.Parameters.Add(new SqlParameter("@endDate", endDate));


                    cmd.ExecuteNonQuery();

                }


            }


        }

        public List<Courses> ListOfAllCourses()
        {
            List<Courses> courses = new List<Courses>();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select*From Courses", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            courses.Add(new Courses()
                            {
                                CourseId = (int)reader["CourseId"],
                                CourseTitle = (string)reader["CourseTitle"],
                                Stream = (string)reader["Stream"],
                                StartDate = (DateTime)reader["StartDate"],
                                EndDate = (DateTime)reader["EndDate"],


                            });

                    }

                }
            }
            return courses;

        }

    }
}
