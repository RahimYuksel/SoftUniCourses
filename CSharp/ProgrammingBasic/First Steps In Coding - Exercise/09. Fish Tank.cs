using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //За рождения си ден Любомир получил аквариум с формата на паралелепипед.
            //Първоначално прочитаме от конзолата на отделни редове размерите му –
            //дължина, широчина и височина в сантиметри.
            //Трябва да се пресметне колко литра вода ще събира аквариума,
            //ако се знае, че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа. 
            // Един литър вода се равнява на един кубичен дециметър / 1л = 1 дм3 /.
            // Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.
            //Вход
            //От конзолата се четат 4 реда:
            // 1.Дължина в см – цяло число в интервала[10 … 500]

            int tankLong = int.Parse(Console.ReadLine());

            // 2.Широчина в см – цяло число в интервала[10 … 300]
            int tankWide = int.Parse(Console.ReadLine());

            //3.Височина в см – цяло число в интервала[10… 200]
            int tankHeight = int.Parse(Console.ReadLine());

            //4.Процент  – реално число в интервала[0.000 … 100.000]
            double percent = double.Parse(Console.ReadLine());

            double tankVolume = tankLong * tankWide * tankHeight;

            double tankVolumeLitres = tankVolume / 1000;

            double PercentLitres = percent / 100;

            Console.WriteLine(tankVolumeLitres * (1-PercentLitres));

           


        }

        
    }
}
