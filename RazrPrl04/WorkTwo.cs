using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrPrl04
{
    class WorkTwo
    {
        static void Main2()
        {
            List<string> strings = new List<string>()
            {
                "Apple",
                "Ananas",
                "Banana",
                "Dostaevkyu",
                "Cherry",
                "Date",
                "Fig",
                "Grapes"
            };

            var stringsSorted = strings.OrderBy(s => s.Length);

            foreach (var item in stringsSorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //----------------------------------------------------

            List<int> numbers = new List<int>()
            { 1, 6, 9, 1, 5, 7, 8, 9, 12, 4, 0, 5};

            numbers.Sort((x, y) => x.CompareTo(y));

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }



            Console.WriteLine();
            //----------------------------------------------------

            string searchTerm = "an";

            strings.Where(x => x.Contains(searchTerm)).ToList().ForEach(x => Console.WriteLine(x));


            //----------------------------------------------------
            List<int> numbers2 = new List<int>()
            { 1, 6, 9, 1, 5, 7, 8, 9, 12, 4, 0, 5};

            numbers2.Select(x => x*2).ToList().ForEach(x => Console.Write(x + " "));

            //-----------------------------------------------------

            List<Student> students2 = new List<Student>()
            {
                new Student { Name = "Alice", Age = 22, Faculty = "Engineering" },
                new Student { Name = "Bob", Age = 25, Faculty = "Science" },
                new Student { Name = "Charlie", Age = 19, Faculty = "Engineering" },
                new Student { Name = "David", Age = 30, Faculty = "Arts" },
                new Student { Name = "Eve", Age = 21, Faculty = "Science" }
            };

            var resquery = students2.Where(x => x.Name.StartsWith("A"));

            foreach (var student in resquery)
            {  Console.WriteLine(student.Name); }

            //---------------------------------------------------

            List<int> numbers3 = new List<int>()
            { 1, 6, 9, 1, 5, 7, 8, 9, 12, 4, 0, 5};

            HashSet<int> numbers4 = new HashSet<int>()
            { 12, 4, 0, 5, 5, 3, 2, 1, 16};

            var numbersList = numbers3.Intersect(numbers4);

            numbersList.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
