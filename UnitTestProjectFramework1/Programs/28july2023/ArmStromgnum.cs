using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._28july2023
{
    internal class ArmStromgnum
    {
        public static void Armstrong()
        {
            int no = 153;
            int sum = 0;
            int copy = no;
            while(no!=0)
            {
                int rem = no % 10;
                sum=sum+(rem*rem*rem);
                no = no / 10;
            }
            if(sum==copy)
            {
                Console.WriteLine(copy + " is an Atmstrong number");
            }
            else
            {
                Console.WriteLine(copy+" it is not an Armstrong number");
            }
        }
    }
}
