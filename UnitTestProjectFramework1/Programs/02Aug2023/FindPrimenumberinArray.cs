using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._02Aug2023
{
    internal class FindPrimenumberinArray
    {
        public static void Prime()
        {
            int[] arr = { 1, 3, 5, 7, 4 };
            for(int i=0; i<arr.Length; i++)
            {
                int c = arr[i];
                int count = 0;
                for(int j=1; j<=c; j++) 
                {
                    if (arr[i]%j == 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine(arr[i] + " is a prime number");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is not a prime number");
                }
            }
        }
    }
}
