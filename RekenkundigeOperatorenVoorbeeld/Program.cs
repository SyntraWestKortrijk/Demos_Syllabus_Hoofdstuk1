using System;

namespace RekenkundigeOperatorenVoorbeeld
{
    class Program
    {
        static void Main()
        {
            double celcius = 12.3;
            Console.Write("Fahrenheit: ");
            Console.WriteLine(celcius * 1.8 + 32);  // 54,14

            int bedragInGeheleEuros = 17;
            Console.Write("Minimum bedrag in muntstukken: ");
            Console.WriteLine(bedragInGeheleEuros % 5);  // 2

            Console.Write("Aantal biljetten van vijf: ");
            Console.WriteLine(bedragInGeheleEuros / 5);// 3 (int) -> gehele deling

            double preciesEuroBedrag = bedragInGeheleEuros;
            Console.Write("Helft van het bedrag: ");
            Console.WriteLine(preciesEuroBedrag / 2); //  8.5 (double) -> gewone deling
        }

    }
}
