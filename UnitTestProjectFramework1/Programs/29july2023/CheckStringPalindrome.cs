using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._29july2023
{
    internal class CheckStringPalindrome
    {
        public static void Stringpalindrome()
        {
            string s = "madam";
            string rev = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                rev = rev + s[i];
            }
            if(s.Equals(rev))
            {
                Console.WriteLine(s + " is a string palindrome");
            }
            else
            {
                Console.WriteLine(s + " is not a string palindromme");
            }
        }
    }
}
