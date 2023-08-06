using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._31july2023
{
    internal class SortArray
    {
        public static void Sort()
        {
            int[] a = { 25, 56, 8, 75, 13 };
            Array.Sort(a);
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
