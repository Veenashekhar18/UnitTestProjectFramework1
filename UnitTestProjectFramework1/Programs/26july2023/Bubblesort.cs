using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bubblesort
    {
        public void SortAsc()
        {
            int[] arr = { 9, 5, 48, 15, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp= arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine();
                Console.Write(arr[i]+" ");
               
            }
            Console.Write(" array is sorted in ascending order ");
        }
    }
}
