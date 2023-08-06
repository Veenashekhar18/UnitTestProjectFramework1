using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._03Aug2023
{
    internal class CountCharacterPositionfromLast
    {
        public static void Countcharacter()
        {
            string s = "kannada";
            char[] c = s.ToCharArray();
            HashSet<char> list = new HashSet<char>();
            for(int i=0; i<c.Length; i++)
            {
                list.Add(c[i]);
            }
            foreach(char ch  in list)
            {
                for(int j=c.Length-1; j>=0; j--)
                {
                    if (ch == c[j])
                    {
                        Console.WriteLine(ch + " is in " + (j + 1) + " position");
                        break;
                    }
                }
            }
        }
    }
}
