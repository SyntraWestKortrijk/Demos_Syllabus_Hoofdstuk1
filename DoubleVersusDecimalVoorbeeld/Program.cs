using System;

namespace DoubleVersusDecimalVoorbeeld
{
    class Program
    {
        static void Main()
        {
            double bedrag1 = 17d;
            decimal bedrag2 = 17m;
            Console.WriteLine(bedrag1 / 3); //5,66666666666667               (double)
            Console.WriteLine(bedrag2 / 3); //5,6666666666666666666666666667 (decimal)
        }
    }
}
