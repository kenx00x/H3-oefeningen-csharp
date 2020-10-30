using System;

namespace String_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een euro bedrag in ");
            double euro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($@"Dit bedrag is { euro * 1.18} dollar.");


            Console.WriteLine($@"{-1 + 4 * 6}");
            Console.WriteLine($@"{(35 + 5) % 7 }");
            Console.WriteLine($@"{ 14 + -4 * 6 / 11}");
            Console.WriteLine($@"{ 2 + 15 / 6 * 1 - 7 % 2}");

            Console.WriteLine();

            Console.WriteLine($@"{ -1.0 + 4.0 * 6.0}");
            Console.WriteLine($@"{ (35.0 + 5.0) % 7.0}");
            Console.WriteLine($@"{ 14.0 + -4.0 * 6.0 / 11.0}");
            Console.WriteLine($@"{ 2.0 + 15.0 / 6.0 * 1.0 - 7.0 % 2.0}");

            Console.ReadLine();
        }
    }
}
