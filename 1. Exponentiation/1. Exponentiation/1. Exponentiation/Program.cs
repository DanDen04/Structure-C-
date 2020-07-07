using System;

namespace _1._Exponentiation
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleInDeg obj = new DoubleInDeg();
            obj.Read();
            Console.WriteLine($"{obj.DisplayInfo()} = {obj.Power()}");
        }
    }
}
