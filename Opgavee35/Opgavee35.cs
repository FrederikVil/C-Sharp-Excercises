using System;

namespace Opgavee35
{
    class Opgavee35
    {
        static void Main(string[] args)
        {
            int tal1, tal2;

            Console.Write("Skriv et tal der er under 100: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv et andet tal der  over 200: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 < 100)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }
            if (tal2 > 200)
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
