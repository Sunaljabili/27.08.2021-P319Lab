using System;

namespace class_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("P319", 1);

            Student[] students = { 
                new Student("Ayxan", "Abdullayev", "@"),
                new Student("Terlan", "Abdullayev", "@")
            };

            foreach(Student stu in students)
            {
                group.AddStudent(stu);
            }


            group.GetStudents();

        }
    }
}
