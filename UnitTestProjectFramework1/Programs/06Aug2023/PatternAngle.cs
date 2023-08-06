using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._06Aug2023
{
    internal class PatternAngle
    {
        public static void Pattern()
        {
            int n = 5;
            for(int i=n; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
