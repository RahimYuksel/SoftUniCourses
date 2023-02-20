using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            
            double pricePen = pens * 5.80;
            double priceMarker = markers * 7.20;
            double priceLitres = litres * 1.20;

            double price = pricePen + priceMarker + priceLitres;
            double discount = percent / 100.0;

            double final = price - (price * discount);


            Console.WriteLine(final);

        }
    }
}
    
