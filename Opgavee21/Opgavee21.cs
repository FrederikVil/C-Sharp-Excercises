using System;

namespace Opgavee21
{
    class Opgavee21
    {
        static void Main(string[] args)
        {

            int tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet Tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 == 20 || tal2 == 20 || tal1+tal2==20)
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
