using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Exponentiation
{
    public class DoubleInDeg
    {
        private double First { get; set; }
        private double Second { get; set; }

        public DoubleInDeg(double first, int second)
        {
            this.First = first;
            this.Second = second;
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
    }
}
