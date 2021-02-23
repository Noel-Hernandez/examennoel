using Lab3_08_01_2021.Models.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_08_01_2021.Models.Data
{
    public class StudentData
    {
        private IConfiguration _configuration;
        string connectionString;

        public StudentData(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            //GetStudentById(5);
        }

        public StudentData()
        {

        }

        public int Insert(Student student)
        {
            //ira el codigo necesario para base de datos

            int resultToReturn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@Major", student.Major);
                command.Parameters.AddWithValue("@Nationality", student.Nationality);
                command.Parameters.AddWithValue("@Age", student.Age);
                //command.ExecuteNonQuery();

                resultToReturn = command.ExecuteNonQuery();
                connection.Close();
            }


            return resultToReturn;

        }
        // leer (select)

        public List<Student> GetStudents()
        {

            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    students.Add(new Student

                    {
                        StudentId = Convert.ToInt32(sqlDataReader["StudentId"]),
                        Name = sqlDataReader["Name"].ToString(),
                        Password = sqlDataReader["Password"].ToString(),
                        Email = sqlDataReader["Email"].ToString(),
                        Age = sqlDataReader["Age"].ToString(),
                        Nationality = sqlDataReader["Nationality"].ToString(),
                        Major = sqlDataReader["Major"].ToString()

                    }

                    );


                }//end while

                connection.Close();
            }// end using

            return students;

        }// end get students


        public List<Nationality> GetNationality()
        {

            List<Nationality> nationality = new List<Nationality>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectNationality", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    nationality.Add(new Nationality

                    {
                        Id = Convert.ToInt32(sqlDataReader["Nationality_Id"]),
                        Name = sqlDataReader["Nationality_Name"].ToString()

                    }

                    );
                }//end while

                connection.Close();
            }// end using

            return nationality;

        }// end get students



        public List<Major> GetMajor()
        {

            List<Major> major = new List<Major>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectMajor", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    major.Add(new Major

                    {
                        Id = Convert.ToInt32(sqlDataReader["Mayor_Id"]),
                        Name = sqlDataReader["Mayor_Name"].ToString()

                    }

                    );
                }//end while

                connection.Close();
            }// end using

            return major;

        }// end get students




        /*   public Student GetStudentById(int id)
           {
               Student student = new Student();
               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                   connection.Open();
                   SqlCommand command = new SqlCommand("SelectStudentById", connection);
                   command.CommandType = System.Data.CommandType.StoredProcedure;
                   command.Parameters.AddWithValue("@StudentId", id);

                   SqlDataReader sqlDataReader = command.ExecuteReader();
                   //this reads the row coming from DB
                   if (sqlDataReader.Read())
                   {
                       student.StudentId = Convert.ToInt32(sqlDataReader["StudentId"]);
                       student.Name = sqlDataReader["Name"].ToString();
                       student.Password = sqlDataReader["Password"].ToString();
                       student.Email = sqlDataReader["Email"].ToString();

                   }
                   connection.Close();
               }
               return student;
           }


           public int Delete(int id)
             {
               int resultToReturn;
               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                   connection.Open();
                   SqlCommand command = new SqlCommand("DeleteStudent", connection);
                   command.CommandType = System.Data.CommandType.StoredProcedure;
                   command.Parameters.AddWithValue("@StudentId", id);
                   resultToReturn = command.ExecuteNonQuery();
                   connection.Close();
               }
               return resultToReturn;
           }

           public int Update(Student student)
           {
               int resultToReturn;
               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                   connection.Open();
                   SqlCommand command = new SqlCommand("UpdateStudent", connection);
                   command.CommandType = System.Data.CommandType.StoredProcedure;

                   command.Parameters.AddWithValue("@StudentId", student.StudentId);
                   command.Parameters.AddWithValue("@Name", student.Name);
                   command.Parameters.AddWithValue("@Email", student.Email);
                   command.Parameters.AddWithValue("@Password", student.Password);

                   resultToReturn = command.ExecuteNonQuery();
                   connection.Close();
               }

               return resultToReturn;
           }*/
    }
}

