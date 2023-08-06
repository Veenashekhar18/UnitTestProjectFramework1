using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._01Aug2023
{
    internal class FirstandSecondMaximumArray
    {
        public static void Maximum()
        {
            int[] a = { 1, 1, 1, 2, 8, 14, 1 };
            int fmax = 0;
            int smax = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= fmax)
                {
                    if (a[i] > fmax)
                    {
                        smax = fmax;
                    }
                    fmax = a[i];
                }
                else if (fmax == smax || smax < a[i])
                {
                    smax = a[i];
                }
            }
            Console.WriteLine(fmax);
            Console.WriteLine(smax);
            
        }
    }
}
