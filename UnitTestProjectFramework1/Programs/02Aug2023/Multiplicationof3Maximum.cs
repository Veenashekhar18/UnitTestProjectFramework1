using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._02Aug2023
{
    internal class Multiplicationof3Maximum
    {
        public static void Multiplication()
        {
            int[] a = { 3, 1, 4, 5, 8 };
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
            int mul = 1;
            for(int i=0; i<3; i++)
            {
                mul = mul * a[i];
            }
            Console.WriteLine(mul+" is the  multiplication of 3 maximum numbers");
        }
    }
}
