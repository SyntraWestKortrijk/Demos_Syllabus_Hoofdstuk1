using System;

namespace DebuggingLocalsVoorbeeld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Lengte in meter?: ");
            double lengteInMeter = double.Parse(Console.ReadLine());

            Console.Write("Breedte in meter?: ");
            double breedteInMeter = double.Parse(Console.ReadLine());

            double vierkanteMeter = lengteInMeter * breedteInMeter;
            double are = vierkanteMeter / 10; // foute berekening moet zijn /100
            double hectare = are / 100;

            Console.WriteLine("\nAantal vierkante meter: " + vierkanteMeter);
            Console.WriteLine("Aantal hectare: " + hectare);
        }

    }
}
