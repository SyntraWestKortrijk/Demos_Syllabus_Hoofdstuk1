using System;

namespace IntParseVoorbeeld2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geboortejaar?: ");
            int geboorteJaar = int.Parse(Console.ReadLine());

            int leeftijd = DateTime.Today.Year - geboorteJaar;
            Console.WriteLine($"Dit jaar word je {leeftijd} jaar oud.");
        }

    }
}
