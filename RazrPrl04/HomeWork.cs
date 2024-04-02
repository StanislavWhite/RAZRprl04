using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrPrl04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 6, 8, 3, 2, 7, 1, 2, 4 };
            int searchHumber = 21;

            Array.Sort(numbers);

            numbers.ToList().ForEach(x => Console.Write(x + " "));


            Console.WriteLine();
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int k = i + 1; int r = numbers.Length - 1;
                while (k < r)
                {
                    int sum = numbers[i] + numbers[k] + numbers[r];

                    if (sum == searchHumber)
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[k]} + {numbers[r]} = {searchHumber} ");
                        break;
                    }
                    else if (sum < searchHumber)
                    {
                        k++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(searchHumber);
        }
    }
}
