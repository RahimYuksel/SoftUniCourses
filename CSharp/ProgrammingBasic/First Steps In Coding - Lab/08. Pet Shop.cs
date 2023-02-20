using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cat = int.Parse(Console.ReadLine());
            int dog = int.Parse(Console.ReadLine());

            double price = cat * 2.5 + dog * 4;
      

            Console.WriteLine($"{price} lv.");


        }
    }
}
