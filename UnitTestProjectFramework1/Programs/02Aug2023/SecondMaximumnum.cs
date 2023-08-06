using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._02Aug2023
{
    internal class SecondMaximumnum
    {
        public static void SecondMax()
        {
            int[] a = { 3, 5, 8, 1, 8 };
            for(int i=0; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("second maximum number in array is " + a[1]);
        }
    }
}
