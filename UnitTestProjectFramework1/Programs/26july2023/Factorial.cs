using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._26july2023
{
    internal class Factorial
    {
        public static void FindFactorial()
        {
            int no = 5;
            int fact = 1;
            for(int i = 0; i < no; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine(fact);

        }
    }
}
