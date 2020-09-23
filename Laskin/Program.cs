using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku:");
            String ekaluku = Console.ReadLine();
            Console.WriteLine("Anna toinen luku:");
            String tokaluku = Console.ReadLine();

            int summa = int.Parse(ekaluku) + int.Parse(tokaluku);
            Console.WriteLine("Summa on " + summa);
        }
    }
}
