using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._28july2023
{
    internal class SumOfEvenDigitsIngivennum
    {
        public static void SumofEvenDigits()
        {
            int no = 4512364;
            int sum = 0;
            while(no!=0)
            {
                int rem = no % 10;
                if(rem%2==0)
                {
                    sum=sum+rem;
                }
                no=no/10;
            }
            Console.WriteLine(sum + " sum of even digits");
        }
    }
}
