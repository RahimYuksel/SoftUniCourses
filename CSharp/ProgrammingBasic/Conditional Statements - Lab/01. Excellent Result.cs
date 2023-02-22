using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. четем оценка (дробно число)
            double grade = double.Parse(Console.ReadLine());

            //2. проверяваме дали числото е >= 5.50, изписваме "Еxcellent!" ако е true.
            if (grade >= 5.50)
            { Console.WriteLine("Excellent!"); }
            

        }
    }
}
