using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._27july2023
{
    internal class SumofElements
    {
        public static void SumofelementsinArray() 
        {
            int[] array = { 3, 4, 8, 12, 6 };
            int sum = 0;
            for(int i=0; i<array.Length-1; i++)
            { 
                sum = sum+ array[i];
            }
            Console.WriteLine(sum+" is the sum of array elements");
        }
    }
}
