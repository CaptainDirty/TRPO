using System;

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
                TRPO_Lab3.Lib.Math_1 math_1 = new TRPO_Lab3.Lib.Math_1();
               double answer =  math_1.Formula(radius, height);
                Console.WriteLine($"{answer}");
            }
            Console.ReadKey();
        }
    }
}
