using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._26july2023
{
    public class Fibonacciseries
    {
        public static void FindFibonacci()
        {
            int fib1 = 0;
            int fib2 = 1;
            Console.WriteLine();
            Console.Write(fib1+" "+fib2+" ");
            for (int i = 0; i <=10; i++) 
            {
              int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                Console.Write(fib3+" ");
            }
            Console.Write(" Fibonacci series ");
        }
    }
}
