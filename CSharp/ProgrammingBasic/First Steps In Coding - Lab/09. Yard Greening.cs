using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvadrat = double.Parse(Console.ReadLine());
            double final = kvadrat * 7.61;

            double otstapka = 0.18 * final;
            double fincen = final - otstapka;




            Console.WriteLine($"The final price is: {fincen} lv.");
                Console.WriteLine($"The discount is: {otstapka} lv.");


        }
    }
}
