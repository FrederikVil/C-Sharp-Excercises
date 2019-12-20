using System;

namespace Opgavee11
{
    class Opgavee11
    {
        static void Main()
        {

            int alder;

            Console.Write("Din alder: ");
            alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Du ser ældre ud end {alder}");
        }
    }
}
