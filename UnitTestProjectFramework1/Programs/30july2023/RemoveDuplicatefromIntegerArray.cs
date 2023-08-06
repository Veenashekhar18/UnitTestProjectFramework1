using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._30july2023
{
    internal class RemoveDuplicatefromIntegerArray
    {
        public static void Remove()
        {
            int[] array = { 12, 15, 18, 12, 15, 10, 24 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = 985;
                    }
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] != 985)
                {
                    Console.WriteLine(array[k]);
                }
            }

        }
    }

}
