using System;

namespace Opgave10
{
    class Opgavee10
    {
        static void Main()
        {
            int number1, number2, number3;

            Console.Write("Første nummer(x): ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet nummer(y): ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Trejde nummer(z): ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resultatet af ({number1}+{number2})*{number3} (x+y)*z er {(number1+number2)*number3}" +
                $"og resultatet af {number1}*{number2}+{number2}*{number3} (x*y+y*z) er {number1*number2+number2*number3}");
        }
    }
}
