using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
       

        //Методы должны быть объявлены как статические.
        delegate double Operation(double R);

        static void Main(string[] args)
        {
            double R = 15.6;    // присваивание радиус
            Console.WriteLine("Радиус шара: " + R);
            Operation oper = Methode1;
            double result = oper(R);
            Console.WriteLine("Длина окружности: " + result);

            oper = Methode2;
            result = oper(R);
            Console.WriteLine("Площадь круга: " + result);

            oper = Methode3;
            result = oper(R);
            Console.WriteLine("Объем шара: " + result);
            Console.Read();
        }
         static double Methode1(double R)
        {
            double D = 2 * Math.PI * R;
            return D;
        }
         static double Methode2(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }
         static double Methode3(double R)
        {
            double V = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
            return V;
        }
   
    }
}