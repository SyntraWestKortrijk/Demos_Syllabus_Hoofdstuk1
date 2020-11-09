using System;

namespace DatatypeBepaaltToegelatenOperatiesVoorbeeld2
{
    class Program
    {
        static void Main()
        {
            int bedrag = 125;
            //Console.Write(bedrag.ToUpper());      // compilefout
            //Console.Write(125.ToUpper());         // compilefout

            double kilometer = 12.3;
            //Console.Write(kilometer.ToUpper());   // compilefout
            //Console.Write(12.3.ToUpper());        // compilefout

            string groet = "Hallo";
            Console.WriteLine(groet.ToUpper());     // HALLO
            Console.WriteLine("wereld".ToUpper());  // WERELD

        }

    }
}
