using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._27july2023
{
    internal class LinearSearchinArray
    {
        public static void LinearSearch()
        {
            int[] a = { 2, 8, 5, 9, 3, 4 };
            int find = 8;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == find)
                {
                    Console.WriteLine(find + " found the element");
                }
            }
        }
    }
}
