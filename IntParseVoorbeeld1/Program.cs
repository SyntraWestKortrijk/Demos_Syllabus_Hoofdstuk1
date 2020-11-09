using System;

namespace IntParseVoorbeeld1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geboortejaar?: ");
            string ingevoerdeGeboortejaar = Console.ReadLine();

            int geboorteJaar = int.Parse(ingevoerdeGeboortejaar);

            int leeftijd = DateTime.Today.Year - geboorteJaar;
            Console.WriteLine($"Dit jaar word je {leeftijd} jaar oud.");
        }

    }
}
