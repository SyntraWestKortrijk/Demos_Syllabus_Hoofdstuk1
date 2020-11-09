using System;

namespace StringNaarIntDoubleDecimalVoorbeeld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geboortejaar?: ");
            string geboortejaarInvoer = Console.ReadLine();

            Console.Write("Lengte?: ");
            string lengteInvoer = Console.ReadLine();

            Console.Write("Bedrag?: ");
            string bedragInvoer = Console.ReadLine();

            //int geboorteJaar = geboortejaarInvoer;  // compilefout: Cannot implicitly convert type 'string' to 'int'.
            int geboortejaar = int.Parse(geboortejaarInvoer);

            //double lengte = lengteInvoer;           // compilefout: Cannot implicitly convert type 'string' to 'double'.
            double lengte = double.Parse(lengteInvoer);

            //decimal bedrag = bedragInvoer;          // compilefout: Cannot implicitly convert type 'string' to 'decimal'.
            decimal bedrag = decimal.Parse(bedragInvoer);

            Console.WriteLine("Geboren in: " + geboortejaar);
            Console.WriteLine("Lengte is: " + lengte);
            Console.WriteLine("Bedrag is: " + bedrag);
        }

    }
}
