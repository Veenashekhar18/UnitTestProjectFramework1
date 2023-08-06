using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._30july2023
{
    internal class Anagram
    {
        public static void CheckAnagram()
        {
            string s1 = "fire";
            string s2 = "fore";
            if(s1.Length == s2.Length) 
            {
                char[] arr = s1.ToCharArray();
                char[] arr2 = s2.ToCharArray();
                Array.Reverse(arr);
                Array.Sort(arr);
                Array.Sort(arr2 );
                string a=new string(arr);
                string b=new string(arr2);
                if(a.Equals(b))
                {
                    Console.WriteLine("the given strings are anagram");
                }
                else
                {
                    Console.WriteLine("the given strings are not anagram");
                }
            }
        }
    }
}
