using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._05Aug2023
{
    internal class PatternNumber1to9
    {
        public static void PatternNumber()
        {
            int n = 1;
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(n + " ");
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
