using System;

namespace Opgavee36
{
    class Opgavee36
    {
        static void Main(string[] args)
        {
            int tal1, tal2;

            Console.Write("Skriv et tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv et andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 >= -10 && tal1 <= 10)
            {
                Console.WriteLine("True");
            }
            else if (tal2 >= -10 && tal2 <= 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
