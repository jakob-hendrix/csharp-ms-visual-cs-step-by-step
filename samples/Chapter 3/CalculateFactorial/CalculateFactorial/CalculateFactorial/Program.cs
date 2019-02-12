﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        private void run()
        {
            int num = 0;
            int workNum = 0;
            num = ++workNum;
            num = workNum++;

            Console.Write("Please enter a positive integer: ");
            string inputValue = Console.ReadLine();
            long factorialValue = CalculateFactorial(inputValue);
            Console.WriteLine($"Factorial({inputValue}) is {factorialValue}, or {inputValue}! = {factorialValue}");
        }

        long CalculateFactorial(string input)
        {
            int inputValue = int.Parse(input);

            long factorial(int dataValue)
            {
                if(dataValue == 1)
                {
                    return 1;
                }
                else
                {
                    return dataValue * factorial(dataValue - 1);
                }
            }

            long factorialValue = factorial(inputValue);
            return factorialValue;
        }
    }
}
