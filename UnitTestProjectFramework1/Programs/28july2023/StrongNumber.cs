using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._28july2023
{
    internal class StrongNumber
    {
        public static void Strong()
        {
            int no = 157;
            int sum = 0;
            int copy = no;
            while(no!=0)
            {
                int rem = no % 10;
                int fact = 1;
                for(int i = rem; i > 1; i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                no = no / 10;
            }
            if(sum== copy)
            {
                Console.WriteLine(copy + " it is a strong number");
            }
            else
            {
                Console.WriteLine(copy + " it is not a strong number");
            }
        }
    }
}
