using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    internal class Merge2Arrays
    {
        public void Merge2() 
        {
            int[] a = { 3, 4, 8, 9, 1 };
            int[] b = { 11, 0, 6, 8,10 };
            int size=a.Length+b.Length;
            int[] c = new int[size];
            int index = 0;
            foreach(int x in a)
            {
                c[index++] = x;
            }
            foreach (int y in b)
            {
                c[index++] = y;
            }
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine();
                Console.Write(c[i]+" ");
             
            }
            Console.Write(" Merged array ");
        }
    }
}
