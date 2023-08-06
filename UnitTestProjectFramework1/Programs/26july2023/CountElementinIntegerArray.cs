using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._26july2023
{
    internal class CountElementinIntegerArray
    {
        public static void Count()
        {
            int[] arr = { 9, 1, 5, 6, 2 };
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
