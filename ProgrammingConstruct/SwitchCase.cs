using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC7: Perform arithmatic operation using SWITCH Case.
    internal class SwitchCase
    {
        public void ArithematicOperation()
        {

            Console.WriteLine("Choose which arithematic operator to perform\n1. Addition\n2. Subtraction\n3" +
                " Multiplication\n4. Division\n");
            Console.Write("You want to perform operator:  ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first no:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second no:  ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int result = a + b;
                    Console.Write("SUM of two no {0} & {1} is:  {2}", a, b, result);
                    break;
                case 2:
                    int result1 = a - b;
                    Console.WriteLine("Differnce between two no {0} & {1} is:  {2}", a, b, result1);
                    break;
                case 3:
                    int result2 = a * b;
                    Console.WriteLine("After Multiplication of the no {0} & {1} we get result: {2}", a, b, result2);
                    break;
                case 4:
                    float result3 = a / b;
                    Console.WriteLine("After division of {0} & {1} we get {2}", a, b, result3);
                    break;
                default:
                    Console.WriteLine("OOPS! Out of arithematic operation choice");
                    break;
            }
        }
    }
}
