using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    // UC11: Program to Flip Coin problem till either Heads or Tails wins 20 times.
    internal class WhileLoop
    {
        public void FlipCoin()
        {
            Random random = new Random();
            int heads = 0;
            int tails = 0;

            while (heads < 20 && tails < 20)
            {
                int toss = random.Next(2);
                if (toss == 0)
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("Tails");
                }
                
            }

            if (heads == 20)
            {
                Console.WriteLine("Head comes 20 times\nHeads wins!");
            }
            else
            {
                Console.WriteLine("Tail comes 20 times\nTails wins!");
            }
        }

    }
}