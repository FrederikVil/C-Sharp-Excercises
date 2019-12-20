using System;

namespace Opgavee33
{
    class Opgavee33
    {
        static void Main(string[] args)
        {
            int tal1;

            Console.Write("Skriv et tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            if (tal1 > 0)
            {

                if (tal1 % 3 == 0 || tal1 % 7 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
