using System;

namespace Opgavee18
{
    class Opgavee18
    {
        static void Main(string[] args)
        {

            int tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tjek om der er et positivt og negativt tal");

            if ((tal1 > 0 && tal2 < 0) || (tal1 < 0 && tal2 > 0))
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
