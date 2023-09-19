using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_maze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();


            List<Student> firstYearStudents = new List<Student>
            {
                new Student {Id=1, Name="Mary", Course="Physics", Grade="A" },
                new Student {Id=2, Name="John", Course="Geography", Grade="B" },
                new Student {Id=3, Name="Peter", Course="Biology", Grade="C" },
                new Student {Id=4, Name="David", Course="Mathematics", Grade="D" },
            };

            Func<Student, string> flesh = (student) => student.Name+" scored "+student.Grade + " in "+student.Course;

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
    }
}
