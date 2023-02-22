using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. четем две цели числа

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            // 2.  отпечатвам по-голямото от двете

            if (a > b)
            { Console.WriteLine(a); }
            else
            { Console.WriteLine(b); }

        }
    }
}
