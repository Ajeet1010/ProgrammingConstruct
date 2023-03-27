using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProgrammingConstruct
{
    // UC5 - Program to find the eligibility of admission on given criteria.
    internal class IfElseIf
    {
        public void EligibilityCriteria()
        {
            Console.Write("Eligibility criteria for admission :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");
                        
            Console.Write("Marks in Maths >=65\nand Marks in Phy >=55\nand Marks in Chem>=50\n");
            Console.Write("Total marks in all three subject >=180\n");
            Console.Write("or Total in Maths and Subject(Physics) >=140\n");
            Console.Write("-------------------------------------\n\n");

            Console.Write("Enter the marks obtained in mathematics:  ");
            int Maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the marks obtained in physics:  ");
            int Phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the marks obtained in chemistry:  ");
            int Chem = Convert.ToInt32(Console.ReadLine());
                       
            int TotalMarks = Maths + Phy + Chem;
            int TotalMP = Maths + Phy;
            int TotalMC = Maths + Chem;
            Console.Write("\nTotal marks of Maths, Physics and Chemistry : {0}\n", TotalMarks);
            Console.Write("Total marks of Maths and  Physics : {0}\n", Maths + Phy);
            Console.Write("Total marks in Maths and Chemistry: {0}\n", TotalMC);

            if (TotalMarks >= 180)
            {
                if (Maths >= 65 && Phy >= 55 && Chem >= 50 && TotalMarks >= 180)
                    Console.Write("The  candidate is eligible for admission.\n");
                else
                    Console.Write("The candidate is not eligible for admission.");
            }
            else if (TotalMP >= 140)
            {
                if (Maths >= 65 && Phy >= 55 && Chem >= 50 && TotalMP >= 140)
                    Console.Write("The  candidate is eligible for admission.\n");
                else
                    Console.Write("The candidate is not eligible for admission.");
            }
            else if (TotalMC >= 140)
            {
                if (Maths >= 65 && Phy >= 55 && Chem >= 50 && TotalMC >= 140)
                    Console.Write("The  candidate is eligible for admission.\n");
                else
                    Console.Write("The candidate is not eligible for admission.");
            }
            else
                Console.Write("The candidate is not eligible for admission.");
            
        }
    }
}
