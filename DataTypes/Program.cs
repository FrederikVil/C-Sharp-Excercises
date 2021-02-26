using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave1();
            //Opgave2();
            //Opgave3();
            //Opgave4();
            //Opgave5();
            //Opgave6();
            //Opgave7();
            //Opgave8();
            //Opgave9();
            //Opgave10();
            //Opgave11();
        }

        public static void Opgave1()
        {
            char bogstav1, bogstav2, bogstav3;

            Console.Write("Skriv bogstav:");
            bogstav1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Skriv bogstav:");
            bogstav2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Skriv bogstav:");
            bogstav3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{bogstav3} {bogstav2} {bogstav1}");
        }

        public static void Opgave2()
        {
            Console.Write("Skriv et tal: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hvor bred skal pyramiden være? ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }

        public static void Opgave3()
        {
            int loginattempts = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Brugernavn: ");
                string navn = Console.ReadLine();

                Console.Write("Adgangskode: ");
                string kode = Console.ReadLine();

                if (navn != "ooga" || kode != "booga")
                {
                    loginattempts++;
                }
                else
                {
                    break;
                }
            }

            if (loginattempts > 2)
                Console.WriteLine("Du har ikke flere login forsøg");
            else
                Console.WriteLine("Succes");
        }

        public static void Opgave4()
        {
            int nummer1, nummer2;
            char operation;

            Console.Write("Første tal: ");
            nummer1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Plus(+), minus(-), divider(/) eller gange(*)?: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Andet tal: ");
            nummer2 = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", nummer1, nummer2, nummer1 + nummer2);
            }
            else if (operation == '-')
            {
                Console.WriteLine($"{nummer1} - {nummer2} = {nummer1 - nummer2}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"{nummer1} * {nummer2} = {nummer1 * nummer2}");
            }
            else if (operation == '/')
            {
                Console.WriteLine($"{nummer1} / {nummer2} = {nummer1 / nummer2}");
            }
            else
            {
                Console.WriteLine("Fejl");
            }
        }

        public static void Opgave5()
        {
            double radius, omkreds;


            Console.Write("Radius på cirklen: ");
            radius = Convert.ToInt32(Console.ReadLine());

            omkreds = 2 * 3.14 * radius;
            Console.WriteLine($"Omkredsen af cirklen er: {omkreds}");

        }

        public static int Opgave6()
        {
            Console.WriteLine("Hello, World!");
            return 0;
        }

        public static void Opgave7()
        {
            double afstand, timer, minutter, sekunder;
            double meterSec, kph, mph;
            double tid;

            Console.Write("Afstand(meter): ");
            afstand = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tid(timer): ");
            timer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tid(minutter): ");
            minutter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tid(sekunder): ");
            sekunder = Convert.ToInt32(Console.ReadLine());

            tid = (timer * 3600) + (minutter * 60) + sekunder;

            meterSec = afstand / tid;
            kph = (afstand / 1000) / (tid / 3600);
            mph = kph / 1.609;

            Console.WriteLine("Your speed in meters/sec is {0}", meterSec);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }

        public static void Opgave8()
        {
            float radius, volume, area;

            Console.Write("Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            volume = 4f / 3f * 3.1415926535f * (radius * radius * radius);
            area = 4 * 3.1415926535f * (radius * radius);

            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Area: {area}");
        }

        public static void Opgave9()
        {
            char symbol;

            Console.Write("Character: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("Det er en lille vokal.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("Det er et tal.");
            else
                Console.Write("Det er et andet symbol.");
        }

        public static void Opgave10()
        {

            int tal1, tal2;
            bool lige;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            lige = ((tal1 % 2 == 0) && (tal2 % 2 == 0)) ? true : false;


            Console.WriteLine
            (lige ? "Begge numre er lige" : "Der er mindst et ulige nummer");

        }

        public static void Opgave11()
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);

            Console.Read();

        }
    }
}
