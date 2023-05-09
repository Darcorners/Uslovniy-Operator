using System;

namespace Obj_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, z;
            double x, y, m;

            Console.WriteLine("Введите число a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число z: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (a < b)
            {
                m = Math.Pow(b, 3) - Math.Cos(a);
            }
            else
            {
                m = Math.Pow(Math.Cos(a), 4);
            }

            if (z == 0)
            {
                x = m + 3;
            }
            else
            {
                x = Math.Pow(m, 1 / 3);
            }

            y = (m * Math.Pow(z, 2) + Math.Pow(a, 2) * b) / (x - Math.Pow(Math.Sin(a * b), 3));

            Console.WriteLine(y);
            Console.WriteLine();

            int A, B, C, D, E;
            int i = 0;

            Console.WriteLine("Введите число А: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D: ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число E: ");
            E = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                i++;
            }
            if (A == C)
            {
                i++;
            }
            if (A == D)
            {
                i++;
            }
            if (A == E)
            {
                i++;
            }
            if (B == C)
            {
                i++;
            }
            if (B == D)
            {
                i++;
            }
            if (B == E)
            {
                i++;
            }
            if (C == D)
            {
                i++;
            }
            if (C == E)
            {
                i++;
            }
            if (D == E)
            {
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(i);
        }
    }
}
