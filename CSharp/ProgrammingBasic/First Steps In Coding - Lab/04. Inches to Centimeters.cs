using System;

namespace Hello_Softuni
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
