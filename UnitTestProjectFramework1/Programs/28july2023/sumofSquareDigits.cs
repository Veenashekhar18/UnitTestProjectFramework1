using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._28july2023
{
    internal class sumofSquareDigits
    {
        public static void Sumofsquaredigit()
        {
            int no = 214;
            int sum = 0;
            while(no!=0)
            {
                int rem = no % 10;
                sum=sum+(rem*rem);
                no = no / 10;
            }
            Console.WriteLine(sum+" sum of square digits of given num");
        }
    }
}
