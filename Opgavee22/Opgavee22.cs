using System;

namespace Opgavee22
{
    class Opgavee22
    {
        static void Main(string[] args)
        {
            int tal1;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());


            if (Math.Abs(tal1 - 100) <= 20 || Math.Abs(tal1 - 200) <= 20)
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
