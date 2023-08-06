using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    internal class Find1n2n3largest
    {
        public static void Findlargest()
        {
            int[] a = { 5, 8, 4, 1, 6 };
            int fl = 0;
            int sl = 0;
            int tl = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] > fl)
                {
                    tl = sl;
                    sl = fl;
                    fl = a[i]; 
                }
                else if (a[i]>sl)
                {
                    tl = sl;
                    sl = a[i];
                }
                else if (a[i]>tl)
                {
                    tl = a[i];
                }
            }
            Console.WriteLine();
            Console.Write(fl+" first largest ");
            Console.Write(sl+" second largest ");
            Console.Write(tl+" third largest");

        }
    }
}
