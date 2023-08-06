using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._04Aug2023
{
    internal class FindMAximumLengthInAStringArray
    {
        public static void StringArray()
        {
            string[] arr = { "ab", "abcd", "abc", "ad", "abcde" };
            string maxlength = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i].Length>maxlength.Length)
                {
                    maxlength = arr[i];
                }
            }
            for(int i=0; i< arr.Length; i++)
            {
                if (arr[i].Length==maxlength.Length)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}
