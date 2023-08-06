using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._03Aug2023
{
    internal class CountOccuranceofWords
    {
        public static void Count()
        {
            string s = "im im a a student";
            string[] s1= s.Split(" ");
            Dictionary<string,int> d = new Dictionary<string,int>();
            for(int i=0; i<s1.Length; i++)
            {
                string str= s1[i];
                if(d.ContainsKey(str))
                {
                    int value = d.GetValueOrDefault(str);
                    value++;
                    d.Add(str, value);
                }
                else
                {
                    d.Add(str, 1);
                }
            }
            Console.WriteLine(d.Keys);
        }
    }
}
