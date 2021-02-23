using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_08_01_2021.Models.Domain
{
    public class Student
    {
        private int studentId;
        private string name;
        private string email;
        private string password;
        private string age;
        private string nationality;
        private string major;
        public Student()
        {
        }

        public Student(int studentId, string name, string email, string password, string age, string nationality, string major)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Age = age;
            this.Nationality = nationality;
            this.Major = major;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Age { get => age; set => age = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Major { get => major; set => major = value; }
    }
}
