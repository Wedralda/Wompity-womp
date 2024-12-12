using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Random rd = new Random();
            int num1 = rd.Next(1, 11);
            int num2 = rd.Next(1, 11);
            int solution = num1 * num2;

            Console.WriteLine($"Příklad: {num1} * {num2}");
            int input = int.Parse(Console.ReadLine());

            if (input == solution)
            {
                Console.WriteLine("Správný výsledek!");
            }
            else
            {
                Console.WriteLine($"Špatně! Výsledek je: {solution}");
            }
    }
    }
}
