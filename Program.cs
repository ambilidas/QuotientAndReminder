using System;

namespace QuotientAndReminder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter divident: ");
            int divident=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor: ");
            int divisor=Convert.ToInt32(Console.ReadLine());

            float quotient=(float)divident/divisor;
            int reminder=divident%divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = "+ reminder);

        }
    }
}