﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Programs._28july2023
{
    internal class SumOfDigitsinGivenNum
    {
        public static void SumofDigits()
        {
            int no = 456896;
            int sum = 0;
            while(no!=0)
            {
                int rem=no%10;
                rem=sum+rem;
                no = no / 10;
            }
            Console.WriteLine(sum + " is sum of digits in the number");
        }
    }
}
