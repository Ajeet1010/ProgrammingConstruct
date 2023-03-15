using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC8: Program that input from USER and print a table of the 2's power.
    internal class ForLoop
    {
        public void Powerof2()
        {
            Console.Write("\nEnter the no to check power value until that power:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
