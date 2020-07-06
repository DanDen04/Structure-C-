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
            this.First = double.Parse(Console.ReadLine());
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

            this.First = result;
            return this.First;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.First);
        }
    }
}
