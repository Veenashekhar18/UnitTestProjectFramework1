using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._26july2023
{
    internal class SwapNumbers
    {
        public static void Swap()
        {
            int a = 10;
            int b = 20;
             b = b - a;
             a = b + a;
            Console.WriteLine();
            Console.Write("value of a is "+a+" ");
            Console.Write(" value of b is "+b);
        }
    }
}
