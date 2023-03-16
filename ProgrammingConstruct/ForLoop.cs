using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC10: Program to print until user entered SQUARE.
    internal class ForLoop
    {
        public void Factorial()
        {
            int i, fact = 1;
            Console.Write("Enter the no to print factorial:  ");
            int num = Convert.ToInt32(Console.ReadLine());

            // using for loop to calculate for loop.
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("\nFactorial of {0} is:  {1}", num, fact);
        }
    }
}
