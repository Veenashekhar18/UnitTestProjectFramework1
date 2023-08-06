using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._01Aug2023
{
    internal class AppendZeroAtLast
    {
        public static void Append()
        {
            int[] a= { 1, 0, 8, 6, 0, 6, 0, 9 };
            int[] b=new int[a.Length];
            int m = 0;
            int n = a.Length - 1;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]!=0)
                {
                    b[m++] = a[i];
                }
            }
            for(int i=0; i<b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
