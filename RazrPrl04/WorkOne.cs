using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrPrl04
{
    class WorkOne
    {
        static void Main1()
        {
            List<Student>students = new List<Student>()
            {
                new Student { Name = "Alice", Age = 22, Faculty = "Engineering" },
                new Student { Name = "Bob", Age = 25, Faculty = "Science" },
                new Student { Name = "Charlie", Age = 19, Faculty = "Engineering" },
                new Student { Name = "David", Age = 30, Faculty = "Arts" },
                new Student { Name = "Eve", Age = 21, Faculty = "Science" }
            };

            //Сортировка по возрасту. Выводятся только те, чей возраст меньше 25 лет.
            Console.WriteLine();
            var studentSortYears = students.Where(x => x.Age < 25);
            Console.WriteLine("SORTING BY AGE ");
            foreach (var item in studentSortYears)
            {
                Console.WriteLine(item.Faculty + " - " + item.Name + " - " + item.Age);
            }

            //Сортировка по имени. Выводятся по алфатиному порядку.
            Console.WriteLine();
            var studentSortName = students.OrderBy(x => x.Name).Select(x => x.Name);
            Console.WriteLine("SORTING BY ALBPHABYTE ");
            foreach (var item in studentSortName)
            {
                Console.WriteLine(item);
            }

            //Сортировка по факультету инженерия.
            Console.WriteLine();
            var studentSortFacultet = students.Where(x => x.Faculty == "Engineering");
            Console.WriteLine("SORTING BY FACULTET ");
            foreach (var item in studentSortFacultet)
            {
                Console.WriteLine(item.Faculty + " - " + item.Name + " - " + item.Age);
            }

            //Средний возраст студентов.
            Console.WriteLine();
            var studentAverageAge = students.Average(x => x.Age);
            Console.WriteLine("STUDENT AVERAGE AGE ");
            Console.WriteLine(studentAverageAge);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
    }
}
