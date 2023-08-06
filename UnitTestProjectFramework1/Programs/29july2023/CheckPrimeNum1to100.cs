using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._29july2023
{
    internal class CheckPrimeNum1to100
    {
        public static void Prime()
        {
            for(int i=1; i<=100;  i++)
            {
                int no = i;
                int count = 0;
                for(int j = 1; j <=no; j++)
                {
                    if(no%j==0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine(no + " is a prime number");
                }
                else
                {
                    Console.WriteLine(no+" is not a prime number");
                }
            }
        }
    }
}
