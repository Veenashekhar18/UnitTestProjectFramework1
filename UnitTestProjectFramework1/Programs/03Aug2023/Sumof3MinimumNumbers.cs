using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._03Aug2023
{
    internal class Sumof3MinimumNumbers
    {
        public static void SumofMaximum()
        {
            int[] a = { 3, 1, 5, 4, 8 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum + " is the sum of 3 minimum numbers");
        }
    }
}
