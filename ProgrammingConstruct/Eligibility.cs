using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC3 - program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    internal class Eligibility
    {
        public void CastVote()
        {
            Console.Write("Enter the candidate's age:  ");
            int age = Convert.ToInt32(Console.ReadLine());

            // checking the eligibility to cast vote.
            if (age >= 18)
                Console.WriteLine("Candidate is Eligible to cast vote");
            else
                Console.WriteLine("Candidate is not Eligible to cast vote");
        }
    }
}
