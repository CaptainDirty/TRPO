using System;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            double height = Convert.ToDouble(Console.ReadLine());
            if (height <= 0)
            {
                Console.WriteLine("Высота не может быть такой... тупица");
            }
            else if (radius <= 0)
            {
                Console.WriteLine("Введите положительный радиус");
            }
            else
            { 
               double answer = Math.Round(Math_1.Formula(radius, height),3);
                Console.WriteLine($"{answer}");
            }
            Console.ReadKey();
        }
    }
}
