using System;

namespace Opgave9
{
    class Opgave9
    {
        static void Main()
        {

            int tal1, tal2, tal3, tal4;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tredje tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fjerde tal: ");
            tal4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Gennemsnittet af {tal1} {tal2} {tal3} {tal4} er {(tal1 + tal2 + tal3 + tal4) / 4}");


        }
    }
}
