using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ресторант отваря врати и предлага няколко менюта на преференциални цени:
            //Пилешко меню –  10.35 лв.
            //Меню с риба – 12.40 лв.
            //Вегетарианско меню  – 8.15 лв.

            //Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
            //Групата ще си поръча и десерт, чиято цена е равна на 20 % от общата сметка(без доставката).
            //Цената на доставка е 2.50 лв и се начислява най - накрая.

            //От конзолата се четат 3 реда:

            //Брой пилешки менюта – цяло число в интервала[0 … 99]
            int chicken = int.Parse(Console.ReadLine());

            //Брой менюта с риба – цяло число в интервала[0 … 99]
            int fish = int.Parse(Console.ReadLine());

            //Брой вегетариански менюта – цяло число в интервала[0 … 99]
            int vegy = int.Parse(Console.ReadLine());


            double chickenPrice = chicken * 10.35;

            double fishPrice = fish * 12.40;

            double vegyPrice = vegy * 8.15;

            double dessertPrice = chickenPrice + fishPrice + vegyPrice;
            dessertPrice = dessertPrice * 0.2;

            double totalSum = chickenPrice + fishPrice + vegyPrice + dessertPrice + 2.50;

            Console.WriteLine(totalSum);


        }
    }
}
