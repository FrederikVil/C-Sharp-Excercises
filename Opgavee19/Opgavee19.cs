using System;

namespace Opgavee19
{
    class Opgavee19
    {
        static void Main(string[] args)
        {

            int tal1, tal2, sum;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tal1 + tal2);

            sum = tal1 + tal2;

            if (tal1 == tal2)
            {
                Console.WriteLine(sum*3);
            }

        }
    }
}
