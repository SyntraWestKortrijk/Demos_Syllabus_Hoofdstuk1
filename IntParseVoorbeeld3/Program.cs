using System;

namespace IntParseVoorbeeld3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geboortejaar?: ");
            int leeftijd = DateTime.Today.Year - int.Parse(Console.ReadLine());
            Console.WriteLine($"Dit jaar word je {leeftijd} jaar oud.");
        }

    }
}
