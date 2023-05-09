using System;

namespace Obj_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a;
            double M = 0;
            int i = 0, n;
            int k = 2, K = 1, I = 1;

            Console.WriteLine("Введите число x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число число a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину ряда: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтветы: ");


            while (i < n)
            {
                i++;
                if (i == 1)
                {
                    M = Math.Pow(x, k) + Math.Pow(a, K) / Math.Pow(Math.Sin(a + x), I);
                }
                else 
                {
                    k += 1;
                    K *= 2;
                    I += 1;
                    M += Math.Pow(x, k) + Math.Pow(a, K) / Math.Pow(Math.Sin(a + x), I);
                }
                Console.WriteLine(Convert.ToString(i) + ": " + M);
            }




        }
    }
}
