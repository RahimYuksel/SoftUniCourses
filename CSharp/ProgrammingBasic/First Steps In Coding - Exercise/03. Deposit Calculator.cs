using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double mlihva = lihva / 100 * deposit;

            double mesec = mlihva / 12;

            double final = deposit + time * mesec;


            Console.WriteLine(final);

        }
    }
}
    
