using System;

namespace Opgavee20
{
    class Opgavee20
    {
        static void Main(string[] args)
        {

            int tal1, tal2;
            int sum1, sum2;

            Console.Write("Første Tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet Tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            sum1 = Math.Abs(tal1 - tal2) * 2;
            sum2 = Math.Abs(tal1 - tal2);

            if (tal1 > tal2)
            {
                Console.WriteLine(sum1);
            }
            else
            {
                Console.WriteLine(sum2);
            }




        }
    }
}
