using System;

namespace MathKlasseFunctionaliteitenVoorbeeld
{
    class Program
    {
        static void Main()
        {
            double zijdeVierkant = 12.3;
            Console.Write("Oppervlakte vierkant: ");
            Console.WriteLine("{0:F2}",Math.Pow(zijdeVierkant, 2));

            double lengteRechthoekZijde1 = 3.0;
            double lengteRechthoekZijde2 = 4.0;
            double kwadraatLengteRechthoekZijde1 = Math.Pow(lengteRechthoekZijde1, 2);
            double kwadraatLengteRechthoekZijde2 = Math.Pow(lengteRechthoekZijde2, 2);
            double somVanDeKwadraten = kwadraatLengteRechthoekZijde1 + kwadraatLengteRechthoekZijde2;
            Console.Write("Lengte schuine zijde: ");
            Console.WriteLine(Math.Sqrt(somVanDeKwadraten));
        }

    }
}
