using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7T1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите стороны (x,y,z) треугольников, начиная с 1, чтобы сравнить их площадь");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());

            double S = CalcS1(x, y, z);
            double S1 = CalcS1(x1, y1, z1);

            Console.WriteLine(S);
            Console.WriteLine(S1);
            
            if (S>S1)
            {
                Console.WriteLine("Площадь первого треугольника больше второго");
            }
            else if (S1>S)
            {
                Console.WriteLine("Площадь второго треугольника больше первого");
            }
            else
            {
                Console.WriteLine("Площадь треугольников равна");
            }
            Console.ReadKey();
        }

        static double CalcS1(double x,double y,double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
