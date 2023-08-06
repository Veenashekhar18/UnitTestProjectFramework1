using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._27july2023
{
    internal class LargestElementInArray
    {
        public static void Largest() 
        {
            int[] array = { 24, 56, 12, 58, 96 };
            int largest = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
               
            }
            Console.WriteLine(largest + " is the largest element in array ");
        
        }
    }
}
