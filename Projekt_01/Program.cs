using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Projekt01
    {
        static void Main(string [] args)
        {


            double a, b, c, d, x1, x2;

            Console.Write("Podaj wartości współczynników :\n");


            Console.Write("Podaj a : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c : ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");

            }

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Delta wynosi = {0}\n", d);
                Console.Write("Występuje jedno rozwiązanie: \n");

                x1 = -b / (2.0 * a);
                x2 = x1;

                Console.Write("x1 = {0}\n", x1);
                Console.Write("x2 = {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Delta wynosi = {0}\n", d);
                Console.Write("Są dwa różne rozwiązania: \n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);


                Console.Write("x1 = {0}\n", x1);
                Console.Write("x2 = {0}\n", x2);
            }
            else
            {
                Console.Write("Delta wynosi = {0}\n", d);
                Console.Write("Brak rozwiązań rzeczywistych \n");
            }
            Console.ReadLine();
        }
    }
}
