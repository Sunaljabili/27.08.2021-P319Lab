using System;
using System.Collections.Generic;
using System.Text;

namespace class_task
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Student(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        public string FullName()
        {
            return $"{Name} {Surname}";
        }
    }
}
