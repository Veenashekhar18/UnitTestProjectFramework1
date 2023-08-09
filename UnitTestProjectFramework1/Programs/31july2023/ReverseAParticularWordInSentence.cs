using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._31july2023
{
    internal class ReverseAParticularWordInSentence
    {
        public static void Reverse()
        {
            string s = "welcome to banglore";
            string[] arr = s.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 1)
                {
                    string a = arr[i];
                    string rev = "";
                    for (int j = a.Length - 1; j >= 0; j--)
                    {
                        rev = rev + a[j];
                    }
                    Console.WriteLine(rev);
                }
                else
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
        
    }
}
