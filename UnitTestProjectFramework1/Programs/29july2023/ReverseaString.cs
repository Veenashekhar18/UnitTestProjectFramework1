using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._29july2023
{
    internal class ReverseaString
    {
        public static void Reverse()
        {
            string s = "avenue";
            string rev = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                rev += s[i];
            }
            Console.WriteLine(rev);
        }

    }
}
