using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    internal class ReverseString
    {
        public static void Reverse()
        {
            String s = "Bengaluru";
            String rev = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine();
            Console.Write(rev);
            Console.Write(" string is reversed");

        }
    }
}
