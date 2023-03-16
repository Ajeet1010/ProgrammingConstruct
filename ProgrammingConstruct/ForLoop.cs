using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC9: Program to reads a number N and prints the sum of squares of N numbers starting from 1..
    internal class ForLoop
    {
        public void SumOfSquare()
        {
            int i, sum = 0;
            Console.Write("Enter the no to find square:  ");
            int num = Convert.ToInt32(Console.ReadLine());

            // using for loop to calculate for loop.
            for (i = 1; i <= num; i++)
            {
                sum += i*i;
            }
            //return sum;

            Console.WriteLine("\nSum of SQUARE until {0} is:  {1}", num, sum);
        }
    }
}
