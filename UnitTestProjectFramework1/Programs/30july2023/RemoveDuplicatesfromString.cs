using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._30july2023
{
    internal class RemoveDuplicatesfromString
    {
        public static void Remove()
        {
            string s = "navodaya";
            char[] c = s.ToCharArray();
            for(int i=0; i<s.Length; i++)
            {
                for(int j=i+1; j<s.Length; j++)
                {
                    if (c[i] == c[j])
                    {
                        c[j] = '-';
                    }
                }
            }
            for(int k=0; k<c.Length; k++)
            {
                if (c[k] != '-')
                {
                    Console.WriteLine(c[k]);
                }
            }
        }
    }
}
