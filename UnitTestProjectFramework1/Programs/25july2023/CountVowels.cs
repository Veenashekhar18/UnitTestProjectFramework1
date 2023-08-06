using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    internal class CountVowels
    {
        public static void count()
        {
            string s = "bengaluru";
          char[] ch=s.ToCharArray();
            int count = 0;
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i]=='a' || ch[i]=='e' | ch[i]=='i' || ch[i]=='o' || ch[i]=='u')
                {
                    count++;
                }
            }
            Console.WriteLine(count+" count of vowels");
        }
    }
}
