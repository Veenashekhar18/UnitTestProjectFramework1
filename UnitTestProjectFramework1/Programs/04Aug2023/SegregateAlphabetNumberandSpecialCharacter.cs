using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._04Aug2023
{
    internal class SegregateAlphabetNumberandSpecialCharacter
    {
        public static void Segregate()
        {
            string s = "1n25,;[3%";
            string alp = "";
            string sc = "";
            string n = "";
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '0' && s[i]<='9')
                {
                    n = n + s[i];
                }
                else if (s[i]>='A' && s[i]<'Z' || s[i] >= 'a' && s[i]<='z') 
                {
                
                    alp = alp + s[i];
                }
               else {
                    sc = sc + s[i];
                }
            
            }
            Console.WriteLine(alp+" "+n+" "+sc);
        }
    }
}
