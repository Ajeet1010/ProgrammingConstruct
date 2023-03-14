using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC4 - Program to find the largest of three numbers..
    internal class Largest
    {
        public void No()
        {
            Console.Write("Enter first no:  ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second no:  ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third no:  ");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered three no are: {0}, {1}, {2}",first, second, third);

            // checking the largest no.
            if (first > second && first > third)
                Console.WriteLine("\nFirst no is largest among three: " + first);
            else if (second > first && second > third)
                Console.WriteLine("\nSecond no is largest among three: " + second);
            else
                Console.WriteLine("\nThird no is largest among three: " + third);
        }
    }
}
