using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._31july2023
{
    internal class PerfectNumberr
    {
        public static void Perfect()
        {
            int no = 28;
            int sum = 0;
            for(int i=1; i<no; i++)
            {
                if(no% i == 0)
                {
                    sum = sum + i;
                }

            }
            if(no==sum)
            {
                Console.WriteLine(no + " is a perfect number");
            }
        }
    }
}
