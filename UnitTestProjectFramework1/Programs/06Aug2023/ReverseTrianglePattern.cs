using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._06Aug2023
{
    internal class ReverseTrianglePattern
    {
        public static void Reverse()
        {
            int n = 5;
            for(int i=n; i>=0; i--)
            {
                for(int j=n; j>0; j--)
                {
                    if(i>=j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
