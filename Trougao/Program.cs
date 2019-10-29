using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trougao
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, yA, xB, yB, xC, yC;
            Console.WriteLine("IZRACUNAVANJE POVRSITE TROUGLA. HERONOV OBRAZAC.\n");

             while (true)
             {
                 try
                 {

                     Console.WriteLine($"Unesite koordinate temena A: ");
                     xA = double.Parse(Console.ReadLine());
                     yA = double.Parse(Console.ReadLine());
                     Console.WriteLine();

                     Console.WriteLine($"Unesite koordinate temena B: ");
                     xB = double.Parse(Console.ReadLine());
                     yB = double.Parse(Console.ReadLine());
                     Console.WriteLine();

                     Console.WriteLine($"Unesite koordinate temena C: ");
                     xC = double.Parse(Console.ReadLine());
                     yC = double.Parse(Console.ReadLine());
                     Console.WriteLine();

                     break;

                 } catch
                 {
                     Console.WriteLine("Uneli ste pogresnu vrednost! Pokusajte ponovo.\n ");
                 }
             }
             double a = Math.Sqrt(Math.Pow(xB - xC,2) + Math.Pow(yB - yC,2));
             double b = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));
             double c = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
            

            Console.WriteLine($"Duzine stranica trougla ABC su: stranica a={a}, stranica b={b}, stranica c={c}. ");
            double s = (a + b + c) / 2;

            Console.WriteLine($"Povrsina trougla je: {Math.Sqrt(s * (s - a) * (s - b) * (s - c))}");

            Console.ReadKey();
        }
    }
}
