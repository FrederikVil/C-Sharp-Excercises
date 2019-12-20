using System;

namespace Opgave8
{
    class Opgave8
    {
        static void Main()
        {
            int tal1;


            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}*{0}={tal1 * 0}");
            Console.WriteLine($"{tal1}*{1}={tal1 * 1}");
            Console.WriteLine($"{tal1}*{2}={tal1 * 2}");
            Console.WriteLine($"{tal1}*{3}={tal1 * 3}");
            Console.WriteLine($"{tal1}*{4}={tal1 * 4}");
            Console.WriteLine($"{tal1}*{5}={tal1 * 5}");
            Console.WriteLine($"{tal1}*{6}={tal1 * 6}");
            Console.WriteLine($"{tal1}*{7}={tal1 * 7}");
            Console.WriteLine($"{tal1}*{8}={tal1 * 8}");
            Console.WriteLine($"{tal1}*{9}={tal1 * 9}");
            Console.WriteLine($"{tal1}*{10}={tal1 * 10}");
        }
    }
}
