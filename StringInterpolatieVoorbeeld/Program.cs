using System;

namespace StringInterpolatieVoorbeeld
{
    class Program
    {
        static void Main()
        {
            string mr = "Michel";
            string openvld = "De Croo";
            Console.WriteLine($"{openvld} was de opvolger van {mr}");
            int regeerPeriode = 4;
            Console.WriteLine($"{mr} regeerde tot in {2016 + regeerPeriode}");
        }
    }
}
