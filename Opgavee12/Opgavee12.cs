using System;

namespace Opgavee12
{
    class Opgavee12
    {
        static void Main()
        {
            int tal;

            Console.Write("Skriv et tal: ");
            tal = Convert.ToInt32(Console.ReadLine());
           
            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.WriteLine();
           
            Console.Write(tal);
            Console.Write(tal);
            Console.Write(tal);
            Console.WriteLine(tal);
            Console.WriteLine();
           
            Console.WriteLine("{0} {0} {0} {0}", tal);
           
            Console.WriteLine("{0}{0}{0}{0}", tal);
        }
    }
}
