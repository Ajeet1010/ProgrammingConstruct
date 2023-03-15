using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC6: Print week days using SWITCH Case.
    internal class SwitchCase
    {
        public void Weekdays()
        {
            Console.Write("Enter the no of day:  ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.Write("It's Monday today");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday today");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday today");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday today");
                    break;
                case 5:
                    Console.WriteLine("Hurrah!\nIt's Friday today");
                    break;
                case 6:
                    Console.WriteLine("It's weekend\nLet's have some fun today's Saturday night");
                    break;
                case 7:
                    Console.WriteLine("Oops! Enjoy moment end today\nIt's Sunday yaar.......");
                    break;
                default:
                    Console.WriteLine("Are you MAD?\nIt's only 7(SEVEN) days in a week");
                    break;
            }
        }
    }
}
