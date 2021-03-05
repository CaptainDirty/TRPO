using System;

namespace TRPO_Lab3.Lib
{
    public class Math_1
    {
        public double Formula(double h, double r)
        {
            if(h <= 0)
            {
                throw new ArgumentException("Переменная h не может быть отрицательной");
            }
            if(r <= 0)
            {
                throw new ArgumentException("Переменная r не может быть отрицательной");
            }
            return 2 * Math.PI * r * h;
        }
    }
}
