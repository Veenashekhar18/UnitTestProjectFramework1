using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._01Aug2023
{
    internal class PrintCombinationofNumbers
    {
        public static void Combination()
        {
            int[] a = { 9, 7, 8, 2, 5, 2, 4, 4, 3, 6 };
            for(int i=0; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] + a[j]==11)
                    {
                        Console.WriteLine(a[i]+" + " + a[j]+" =11");
                        break;
                    }
                }
            }
        }
    }
}
