using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._06Aug2023
{
    internal class PatternAlphabets
    {
        public static void PatternAlph()
        {
            char ch = 'A';
            for(int i=1; i<=5;  i++)
            {
                for(int j=1; j<=5; j++)
                {
                    Console.Write(ch+" ");
                    ch++;
                }
                Console.WriteLine();
            }
        }
    }
}
