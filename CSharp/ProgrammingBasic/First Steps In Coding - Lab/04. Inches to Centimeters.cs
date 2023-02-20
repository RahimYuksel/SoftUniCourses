using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double inch = double.Parse("2.54");

            Console.WriteLine(a * inch);


        }
    }
}
