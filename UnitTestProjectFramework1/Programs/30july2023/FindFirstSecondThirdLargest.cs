using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._30july2023
{
    internal class FindFirstSecondThirdLargest
    {
        public static void Findlargest()
        {
            int[] arr = { 15, 58, 54, 12, 3, 4 };
            int fl = 0;
            int sl = 0;
            int tl= 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > fl)
                {
                    tl = sl;
                    sl = fl;
                    fl = arr[i];
                }
                else if (arr[i] > sl)
                {
                    tl=sl;
                    sl = arr[i];
                }
                else if (arr[i] > tl)
                {
                    tl = arr[i];
                }
            }
            Console.WriteLine(fl + " is the first largest in array");
            Console.WriteLine(sl+" is the second largest in array");
            Console.WriteLine(tl+" is the third larges in array");
        }
    }
}
