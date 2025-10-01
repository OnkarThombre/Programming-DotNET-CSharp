
//Program to Check Whether a Given Number is Even or Odd
using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check Whether a Given Number is Even or Odd");
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is a EVEN number");
            }
            else
            {
                Console.WriteLine(num + " ODD number");
            }
        }
    }
}
