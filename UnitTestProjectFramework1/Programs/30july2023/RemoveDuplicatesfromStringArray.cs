using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._30july2023
{
    internal class RemoveDuplicatesfromStringArray
    {
        public static void RemoveDuplicate()
        {
            string[] arr = { "hi", "hello", "hi", "hey", "bye", "hello" };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        arr[i] = "56";
                    }
                }
            }
            for(int k=0; k<arr.Length; k++)
            {
                if (arr[k]!="56")
                {
                    Console.WriteLine(arr[k]);
                }
            }
        }
    }
}
