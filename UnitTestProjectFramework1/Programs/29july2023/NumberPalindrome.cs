using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._29july2023
{
    internal class NumberPalindrome
    {
        public static void Palindrome()
        {
            int no = 121;
            int copy = no;
            int sum = 0;
            while(no!=0)
            {
                int rem = no % 10;
                sum=(sum*10) + rem;
                no = no / 10;

            }
            if(sum == copy)
            {
                Console.WriteLine(copy + " is a number palindrome");
            }
            else
            {
                Console.WriteLine(copy+" is not a number palindrome");
            }
        }
    }
}
