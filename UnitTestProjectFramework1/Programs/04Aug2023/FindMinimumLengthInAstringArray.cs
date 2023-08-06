using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._04Aug2023
{
    internal class FindMinimumLengthInAstringArray
    {
        public static void StringArray()
        {
            string[] arr = { "ab", "abcd", "abc", "ad", "abcde" };
            string minlength = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < minlength.Length)
                {
                    minlength = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == minlength.Length)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}
