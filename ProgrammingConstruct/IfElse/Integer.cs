using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct.IfElse
{
    // UC1-  Program to accept two integers and check whether they are equal or not.
    internal class Integer
    {
        public void Equals()
        {
            Console.Write("Enter first integer:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer:  ");
            int b = Convert.ToInt32(Console.ReadLine());

            // checking input integers are equals or not.
            if (a == b)
                Console.WriteLine("Integers are Equals");
            else
                Console.WriteLine("Integers are not Equals");
        }
    }
}
