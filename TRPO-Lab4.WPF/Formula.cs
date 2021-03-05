using System;
using System.Collections.Generic;
using System.Text;

namespace TRPO_Lab4.WPF
{
    public static class Formula
    {
        public static double Radius { get; set; }
        public static double Height { get; set; }
        //Переменные для записи результата рассчетов
        public static double Result { get; set; }

        public static double Decision(double radius, double height)
        {
            return Math.PI * radius * height;
        }
        public static void Solve()
        {
           Result  = Decision(Radius, Height);
        }
    }
}
