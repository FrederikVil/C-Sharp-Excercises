using System;

namespace Opgavee13
{
    class Opgavee13
    {
        static void Main()
        {
            int tal;

            Console.Write("Enter a number: ");
            tal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", tal);
            Console.WriteLine("{0} {0}", tal);
            Console.WriteLine("{0} {0}", tal);
            Console.WriteLine("{0} {0}", tal);
            Console.WriteLine("{0}{0}{0}", tal);
        }
    }
}
