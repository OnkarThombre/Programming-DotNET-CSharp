//Program to Convert Decimal to Binary
using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            /*int revBinary = 0;
            while(num > 0)
            {
                int last = num % 2;
                revBinary = revBinary * 10 + last;

                num /= 2;
            }                                   gives wrong output for staring binary number with 0

            int binary = 0;
            while(revBinary > 0)
            {
                int last = revBinary % 10;
                revBinary /= 10;
                binary = binary * 10 + last;
            }

            Console.WriteLine($"Binary of {temp} is {binary}");*/

            /*string binary = "";
            while(num > 0)
            {
                int rem = num % 2;
                binary = binary + rem;
                num /= 2;
            }
            Console.WriteLine($"Binary of {temp} is {binary}"); */


        }
    }
}
