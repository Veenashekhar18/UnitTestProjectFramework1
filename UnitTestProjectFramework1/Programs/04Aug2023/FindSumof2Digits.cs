using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._04Aug2023
{
    internal class FindSumof2Digits
    {
        public static void  Findsum()
        {
            string s = "a11b12c3";
                int sum = 0;
            int tsum =0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int n = s[i] - 48;
                    tsum = tsum * 10 + n;
                }

                else
                {
                    sum = sum + tsum;
                    tsum = 0;
                }
            }
            sum = sum + tsum;
            Console.WriteLine(sum);
        }
    }
}
