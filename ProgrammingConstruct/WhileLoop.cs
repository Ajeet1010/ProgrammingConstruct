using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC12: Program to print sum of first five natural numbers.
    internal class WhileLoop
    {
        public void SumofNatural()
        {
            int i = 1, sum = 0;

            Console.Write("The first 5 natural number are : ");
            while (i <= 5)
            {
                sum = sum + i;
                Console.Write("{0} ", i);
                i++;
            }
            Console.Write("\nThe Sum of first five natural no is : {0}\n", sum);
        }

    }
}