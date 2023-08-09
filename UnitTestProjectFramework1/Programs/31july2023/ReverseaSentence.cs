using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._31july2023
{
    internal class ReverseaSentence
    {
        public static void Reverse()
        {
            string s = "Lead a life you want";
            string[] arr = s.Split(' ');
            for(int  i=arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
    }
}
