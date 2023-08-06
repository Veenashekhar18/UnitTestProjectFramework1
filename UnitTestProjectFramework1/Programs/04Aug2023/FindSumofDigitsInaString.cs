using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._04Aug2023
{
    internal class FindSumofDigitsInaString
    {
        public static void FindSum()
        {
            string s = "a2b1d3";
            int sum = 0;
            for(int i=1; i<s.Length; i++)
            {
                char c = s[i];
                if(c>'0' &&  c<='9')
                {
                    sum = sum + (c - 48);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
