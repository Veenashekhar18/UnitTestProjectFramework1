using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._01Aug2023
{
    internal class FindFirstandSecondMinimuminArray
    {
        public static void Find()
        {
            int[] arr = { 1, 1, 8, 2, 3, 1 };
            int fmin = arr[0];
            int smin = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] <= fmin)
                {
                    if (arr[i] < fmin)
                    {
                        smin = fmin;
                    }
                    fmin = arr[i];
                }
                else if (fmin == smin || smin > arr[i])
                {
                    smin = arr[i];
                }
            }
            Console.WriteLine(fmin);
            Console.WriteLine(smin);
        }
    }
}
