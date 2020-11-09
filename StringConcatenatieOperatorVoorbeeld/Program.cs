using System;

namespace StringConcatenatieOperatorVoorbeeld
{
    class Program
    {
        static void Main()
        {
            string socialist = "Di Rupo";
            string christenDemocraat = "Leterme";
            int ambt = 2;

            Console.WriteLine(socialist + " was de opvolger van " + christenDemocraat + " " + ambt);

            int regeerPeriode = 4;
            Console.WriteLine(socialist + " regeerde tot in " + (2010 + regeerPeriode));
        }

    }
}
