using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, r2;
            int l;

            while (true)
            {
                Console.WriteLine("Izracunati:\n" +
                                    "1 - Povrsinu kruga\n" +
                                    "2 - Obim kruga\n" +
                                    "3 - Duzina luka (l)\n" +
                                    "4 - Povrsina kruznog isecka\n" +
                                    "5 - Povrsina prstena\n" +
                                    "6 - Izlaz\n" +
                                    "=============================\n");
                Console.Write($"Izbor: ");
                char izbor = Console.ReadKey().KeyChar;
                Console.WriteLine();



                switch (izbor)
                {
                    case '1':

                        try
                        {
                            Console.Write("Unesite vrednost za poluprecnik: ");
                            r = double.Parse(Console.ReadLine());

                            Console.WriteLine($"Povrsina kruga je: {r * r * Math.PI }\n");

                        }
                        catch
                        {
                            Console.WriteLine("Greska! Pokusajte ponovo!\n");
                        }
                        break;

                    case '2':

                        try
                        {
                            Console.Write("Unesite vrednost za poluprecnik: ");
                            r = double.Parse(Console.ReadLine());

                            Console.WriteLine($"Obim kruga je: {2 * r * Math.PI }\n");
                        }
                        catch
                        {
                            Console.WriteLine("Greska! Pokusajte ponovo!\n");
                        }

                        break;

                    case '3':

                        try
                        {
                            Console.Write("Unesite vrednost za poluprecnik: ");
                            r = double.Parse(Console.ReadLine());

                            Console.Write("Unesite vrednost za ugao α: ");
                            l = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Duzina luka je: {(r * Math.PI * l) / 180}\n");
                        }
                        catch
                        {
                            Console.WriteLine("Greska! Pokusajte ponovo!\n");
                        }

                        break;

                    case '4':

                        try
                        {

                            Console.Write("Unesite vrednost za poluprecnik: ");
                            r = double.Parse(Console.ReadLine());

                            Console.Write("Unesite vrednost za ugao α: ");
                            l = int.Parse(Console.ReadLine());
                            if (l > 0 && l < 360)
                            {
                                Console.WriteLine($"Povrsina kruznog isecka je: {(r * r * Math.PI * l) / 360}\n");
                            }
                            else
                            {
                                Console.WriteLine("Uneli ste pogresnu vrednost za ugao α! Pokusajte ponovo!\n");
                                break;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Greska! Pokusajte ponovo!\n");
                        }

                        break;

                    case '5':

                        try
                        {

                            Console.Write("Unesite vrednost za poluprecnik r1: ");
                            r = double.Parse(Console.ReadLine());

                            Console.Write("Unesite vrednost za poluprecnik r2: ");
                            r2 = double.Parse(Console.ReadLine());

                            if (r > r2)
                            {
                                Console.WriteLine($"Povrsina prstena je:  {(r * r - r2 * r2) * Math.PI}\n");
                            }
                            else
                            {
                                Console.WriteLine($"Povrsina prstena je:  {(r2 * r2 - r * r) * Math.PI}\n");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Greska! Pokusajte ponovo!\n");
                        }


                        break;

                    case '6':

                        Console.WriteLine("Dovidjenja!");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("Greska!");
                        break;


                }
            }

            
        }
    }
}
