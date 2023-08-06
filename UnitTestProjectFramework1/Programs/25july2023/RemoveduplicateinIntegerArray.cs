using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs
{
    internal class RemoveduplicateinIntegerArray
    {
        public static void Removeduplicate()
        {
            int[] a = { 10, 15, 45, 16, 2 };
            for(int i=0; i<a.Length; i++) 
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        a[i] = 100;
                    }
                }
            }
            for(int k=0; k<a.Length; k++)
            {
                if (a[k] == 100) 
                {
                    Console.WriteLine();
                    Console.Write(a[k]+" ");
                    Console.Write(" duplictes removed");
                }
                    
            }
        }
    }
}
