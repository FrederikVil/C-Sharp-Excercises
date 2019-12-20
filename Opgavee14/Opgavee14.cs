using System;

namespace Opgavee14
{
    class Opgavee14
    {
        static void Main()
        {

            int tal;

            Console.Write("Celsius: ");
            tal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", tal + 273);
            Console.WriteLine("Fahrenheit = {0}", tal * 18 / 10 + 32);
             
        }
    }
}
