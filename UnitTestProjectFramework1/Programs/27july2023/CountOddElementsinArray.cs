using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._27july2023
{
    internal class CountOddElementsinArray
    {
        public static void CountOdd()
        {
            int[] arr = { 5, 6, 1, 7, 9, 13 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                }
                System.Console.WriteLine(count+" count of the elements");
            }
        }
    }
}
