using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseprogram
{
    class flipcoin
    {
        public static void Main(string[] args)
        {
            int headCount = 0;
            int tailCount = 0;

            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("Enter the how many times want to flip coin");
            int flip = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < flip; i++)
            {
                Console.WriteLine(i);
                //create a object
                Random random = new Random();
                //invoking next method from random class
                //next(2) gives 2 values 0 and 1
                //we can change 2 into how many values we needed
                int num = random.Next(2);
                //printing 0 and 1 to console
                Console.WriteLine("Random number from system " + num);
                if (num == 0)
                {
                    Console.WriteLine("Print Tail for " + num);
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Print Head for " + num);
                    headCount++;
                }

            }

            headpercentage = (headCount * 100) / flip;
            tailpercentage = (tailCount * 100) / flip;
            Console.WriteLine("Headpercentage   " + headpercentage);
            Console.WriteLine("Tailpercentage   " + tailpercentage);
        }
    }
}
