using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._05Aug2023
{
    internal class Pattern
    {
        public static void pattern()
        {
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
