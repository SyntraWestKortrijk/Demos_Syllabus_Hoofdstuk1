using System;

namespace CastOperatieVoorbeeld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Aantal centimeters?: ");
            double centimeters = double.Parse(Console.ReadLine());

            double meters = centimeters / 100;
            Console.WriteLine($"Aantal meters: {meters}");

            //int geheleMeters = meters;    // compilefout: Cannot implicitly convert type 'double' to 'int'...
            int geheleMeters = (int)meters; // cast operatie
            Console.WriteLine($"Aantal gehele meters: {geheleMeters}");
        }

    }
}
