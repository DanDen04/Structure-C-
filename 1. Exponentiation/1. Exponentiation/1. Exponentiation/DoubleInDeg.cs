using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Exponentiation
{
    public class DoubleInDeg
    {
        private double First { get; set; }
        private int Second { get; set; }

        public void Read()
        {
            Console.Write("Введите число: ");
            this.First = double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            this.Second = int.Parse(Console.ReadLine());
        }

        public double Power()
        {
            double result = 1.0;

            if (this.Second >= 0)
            {
                for (int i = 0; i < this.Second; i++)
                {
                    result *= this.First;
                }
            }
            else
            {
                for (int i = 0; i > this.Second; i--)
                {
                    result *= (1 / this.First);
                }
            }

            return result;
        }

        public string DisplayInfo()
        {
            return $"{this.First} ^ {this.Second}";
        }
    }
}
