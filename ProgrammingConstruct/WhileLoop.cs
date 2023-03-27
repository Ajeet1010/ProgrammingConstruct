using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC12: Program to reverse a string .
    internal class WhileLoop
    {
        public void ReverseString()
        {
            Console.Write("Enter the word or string to Reverse:  ");
            String userinput = Console.ReadLine();
            string ReversedWord = " ";
            char[] ch = userinput.ToCharArray();
            Array.Reverse(ch);
            string reverse = new String(ch);
            Console.WriteLine(reverse);

            
        }

    }
}