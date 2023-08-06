using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._05Aug2023
{
    internal class NumberTrianglePattern
    {
        public static void Trianglepattern()
        {
            int n = 5;
            for(int i=n; i>0; i--) 
            {
                for(int j=1; j<=n; j++)
                {
                    if(i<=j)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
