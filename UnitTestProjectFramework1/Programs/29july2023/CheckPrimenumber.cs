using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._29july2023
{
    internal class CheckPrimenumber
    {
        public static void Prime()
        {
            int no= 5;
            int count = 0;
            for(int i=1; i<=no; i++) 
            { 
                if(no%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine(no+" is a prime number");
            }
            else
            {
                Console.WriteLine(no+" it is not a prime number");
            }
        }
    }
}
