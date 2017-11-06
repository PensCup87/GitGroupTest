using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGroupTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (1 < 2 || 5 > 4)
            {
                Console.WriteLine("Math works");
            }
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("ok");
             }
            else
            {
                Console.WriteLine("not ok");
            }
            int remainder = 10 % 4;
            Console.WriteLine(remainder);
        }
    }
}
