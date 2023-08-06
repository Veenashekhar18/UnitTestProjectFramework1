using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._02Aug2023
{
    internal class Find3MinimuminArray
    {
        public static void Minimum()
        {
            int[] a = { 1, 1, 3, 2, 8, 14 };
            int fmin = a[0];
            int smin = a[0];
            int tmin = a[0];
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]< fmin)
                {
                    if (a[i]!=fmin)
                    {
                        tmin = smin;
                        smin = fmin;
                    }
                }
                else if (a[i]<= smin || fmin==smin)
                {
                    if (a[i]<smin)
                    {
                        tmin=smin;
                    }
                    smin = a[i];
                }
                else if (a[i]<tmin || tmin==smin || fmin==tmin)
                {
                    tmin = a[i];
                }
            }
            Console.WriteLine(fmin);
            Console.WriteLine(smin);
            Console.WriteLine(tmin);
        }
    }
}
