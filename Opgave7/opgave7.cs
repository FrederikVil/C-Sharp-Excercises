using System;

namespace Opgave7
{
    class Opgave7
    {
        static void Main()
        {
            int tal1, tal2;


            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Første tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}+{tal2}={tal1+tal2}");
            Console.WriteLine($"{tal1}-{tal2}={tal1 - tal2}");
            Console.WriteLine($"{tal1}*{tal2}={tal1 * tal2}");
            Console.WriteLine($"{tal1}/{tal2}={tal1 / tal2}");
            Console.WriteLine($"{tal1}%{tal2}={tal1 % tal2}");

            
        }
    }
}
