using System;
using System.Collections.Generic;
using System.Text;

namespace class_task
{
    class Group
    {
        public string No { get; set; }
        public int Limit { get; set; }
        private Student[] _students = { };

        public Group(string no, int limit)
        {
            No = no;
            Limit = limit;
        }

        public void AddStudent(Student student)
        {
            if(_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;

                Console.WriteLine($"{student.FullName()} added group -> {No}");
            } else
            {
                Console.WriteLine($"{student.FullName()} can't added group -> {No}");
            }
        }

        public void GetStudents()
        {
            Console.WriteLine($"\n----- Group {No} Students -----");
            foreach(Student stu in _students)
            {
                Console.WriteLine(stu.FullName());
            }
            Console.WriteLine($"----- End -----\n");
        }
    }
}
