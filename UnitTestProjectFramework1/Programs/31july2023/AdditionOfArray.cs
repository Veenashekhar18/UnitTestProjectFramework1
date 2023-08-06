using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._31july2023
{
    internal class AdditionOfArray
    {
        public static void Addition()
        {
            int[] a = { 5, 1, 3, 9 };
            int[] b = { 9, 4, 3, 7, 8 };
            int length;
            if (a.Length > b.Length)
            {
                length = a.Length;
            }
            else
            {
                length = b.Length;
            }
            int[] c= new int[length];
            for(int i = 0; i < length; i++)
            {
                try
                {
                    c[i] = a[i] + b[i];
                }
                catch (Exception e)
                {
                    if(a.Length > b.Length)
                    {
                        c[i] = a[i];
                    }
                    if(a.Length<b.Length)
                    {
                        c[i] = b[i];
                    }
                }
                
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(c[i]);
            }
        }
    }
}
