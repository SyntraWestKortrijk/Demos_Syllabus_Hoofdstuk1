using System;

namespace IntParseVoorbeeld4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geboortejaar?: ");
            Console.WriteLine($"Dit jaar word je {DateTime.Today.Year - int.Parse(Console.ReadLine())} jaar oud.");

        }

    }
}
