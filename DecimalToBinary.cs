//Program to Convert Decimal to Binary
using System;
//using System.Text;
namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int binary = 0;
            int pow = 1;
            while(temp > 0)
            {
                int last = temp % 2;
                temp /= 2; // ****
                binary = binary + (last * pow);
                pow *= 10;
            }
            Console.WriteLine("binary is " + binary);

        }
    }
}
