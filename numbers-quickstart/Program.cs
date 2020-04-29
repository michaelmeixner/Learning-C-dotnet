using System;

namespace numbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);
        }
        static void Main(string[] args)
        {
            // WorkingWithIntegers();
            // OrderPrecedence();
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double a2 = 5;
            double b2 = 4;
            double c2 = 2;
            double d2 = (a2 + b2) / c2;
            Console.WriteLine(d2);

            double e2 = 19;
            double f2 = 23;
            double g2 = 8;
            double h2 = (e2 + f2) / g2;
            Console.WriteLine(h2);

            double max2 = double.MaxValue;
            double min2 = double.MinValue;
            Console.WriteLine($"The range of double is {min2} to {max2}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal min3 = decimal.MinValue;
            decimal max3 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min3} to {max3}");

            double a3 = 1.0;
            double b3 = 3.0;
            Console.WriteLine(a3 / b3);

            decimal c3 = 1.0M;
            decimal d3 = 3.0M;
            Console.WriteLine(c3 / d3);
        }
    }
}