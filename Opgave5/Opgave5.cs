using System;

namespace Opgave5
{
    class Opgave5
    {
        public static void Main()
        {
            int tal1, tal2;

            Console.Write("Skriv første tal:");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv andet tal:");
            tal2 = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine($"Efter swap {tal2} {tal1}");
        }
    }
}
