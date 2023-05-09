using System;

namespace Obj_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0, xk, xd, a, B;
            double x, M;
            int i = 0;

            Console.WriteLine("Введите число первое число x: ");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число последнее число x: ");
            xk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            xd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число число a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число число B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nОтветы: ");

            x = x0;

            while (x < xk)
            {
                i++;
                x = x + xd;
                M = 2.48 + Math.Cos(Math.Sin(B)) / Math.Pow(Math.E, a - B) + Math.Pow(x, 3);
                Console.WriteLine(Convert.ToString(i) + ": " + M);
            }




        }
    }
}
