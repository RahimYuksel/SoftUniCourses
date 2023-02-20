using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int times = pages / time;

            int final = times / days;


            Console.WriteLine(final);

        }
    }
}
    
