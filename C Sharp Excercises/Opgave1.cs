using System;

namespace C_Sharp_Excercises
{
    class Opgave1
    {
        static void Main()
        {

            string str1, str2;

            Console.Write("Fornavn: ");
            str1 = Convert.ToString(Console.ReadLine());

            Console.Write("Efternavn: ");
            str2 = Convert.ToString(Console.ReadLine());

            if (str1 != "Frederik")
            {

                if (str1 == "Vigor")
                {
                    Console.WriteLine("Victor er en taber :)");
                }
                else
                {
                    Console.WriteLine("Det er ikke mit fornavn");
                }              

            } 
            else if (str2 != "Vilhelmsen")
            {
                Console.WriteLine("Det er ikke mit efternavn");
            }
            
            else
            {
                Console.WriteLine("Yup, det er mit navn");
            }

            
        }
    }
}
