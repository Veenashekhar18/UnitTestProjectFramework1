using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._27july2023
{
    internal class SmallestInArray
    {
        public static void Smallest()
        {
            int[] a = { 8, 15, 45, 16, 3 };
            int smallest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < smallest)
                {
                    smallest = a[i];
                }
            }
            Console.WriteLine(smallest + " is the smallest element in array");
        }
    }
}
