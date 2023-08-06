using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._05Aug2023
{
    internal class NumberPatternreverse
    {
        public static void Numberpattern()
        {
            int n = 5;
            for(int i=5; i>=1; i--) 
            { 
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
