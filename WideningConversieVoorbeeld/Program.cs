using System;

namespace WideningConversieVoorbeeld
{
    class Program
    {
        static void Main()
        {
            int afstand = 123;
            Console.WriteLine($"Afstand: {afstand}");

            double halveAfstand = afstand; // double <- int (widening)
            halveAfstand = halveAfstand / 2;
            Console.WriteLine($"Helft van deze afstand: {halveAfstand}");
        }

    }
}
