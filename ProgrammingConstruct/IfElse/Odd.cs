using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct.IfElse
{
    // UC2-  Program to check whether a given number is even or odd..
    internal class Odd
    {
        public void No()
        {
            Console.Write("Enter the no:  ");
            int a = Convert.ToInt32(Console.ReadLine());

            // checking given no is EVEN OR ODD.
            if (a % 2 == 0)
                Console.WriteLine("Entered no is Even");
            else
                Console.WriteLine("Entered no is ODD");
        }
    }
}
