using System;

namespace BasicOpgaver
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
            //Opgave12();
            //Opgave13();
            //Opgave14();
            //Opgave15();
            //Opgave16();
            //Opgave17();
            //Opgave18();
            //Opgave19();
            //Opgave20();
            //Opgave21();
            //Opgave22();
            //Opgave23();
            //Opgave24();
            //Opgave25();
            //Opgave26();
            //Opgave27();
            //Opgave33();
            //Opgave35();
            //Opgave36();
            

        }

        public static void Opgave1()
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

        public static void Opgave2()
        {
            int sum;
            sum = 2 + 2;

            Console.WriteLine($"2+2={sum}");
        }

        public static void Opgave3()
        {
            int sum;
            sum = 2 - 2;

            Console.WriteLine($"2-2={sum}");
        }

        public static void Opgave4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        public static void Opgave5()
        {
            int tal1, tal2;

            Console.Write("Skriv første tal:");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv andet tal:");
            tal2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Efter swap {tal2} {tal1}");
        }

        public static void Opgave6()

        {
            int tal1, tal2, tal3;


            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Første tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Første tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tal1 * tal2 * tal3);
        }

        public static void Opgave7()
        {
            int tal1, tal2;


            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Første tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}+{tal2}={tal1 + tal2}");
            Console.WriteLine($"{tal1}-{tal2}={tal1 - tal2}");
            Console.WriteLine($"{tal1}*{tal2}={tal1 * tal2}");
            Console.WriteLine($"{tal1}/{tal2}={tal1 / tal2}");
            Console.WriteLine($"{tal1}%{tal2}={tal1 % tal2}");
        }

        public static void Opgave8()
        {
            int tal1;


            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}*{0}={tal1 * 0}");
            Console.WriteLine($"{tal1}*{1}={tal1 * 1}");
            Console.WriteLine($"{tal1}*{2}={tal1 * 2}");
            Console.WriteLine($"{tal1}*{3}={tal1 * 3}");
            Console.WriteLine($"{tal1}*{4}={tal1 * 4}");
            Console.WriteLine($"{tal1}*{5}={tal1 * 5}");
            Console.WriteLine($"{tal1}*{6}={tal1 * 6}");
            Console.WriteLine($"{tal1}*{7}={tal1 * 7}");
            Console.WriteLine($"{tal1}*{8}={tal1 * 8}");
            Console.WriteLine($"{tal1}*{9}={tal1 * 9}");
            Console.WriteLine($"{tal1}*{10}={tal1 * 10}");
        }

        public static void Opgave9()
        {

            int tal1, tal2, tal3, tal4;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tredje tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fjerde tal: ");
            tal4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Gennemsnittet af {tal1} {tal2} {tal3} {tal4} er {(tal1 + tal2 + tal3 + tal4) / 4}");
        }

        public static void Opgave10()
        {
            int number1, number2, number3;

            Console.Write("Første nummer(x): ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet nummer(y): ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Trejde nummer(z): ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resultatet af ({number1}+{number2})*{number3} (x+y)*z er {(number1 + number2) * number3}" +
                $"og resultatet af {number1}*{number2}+{number2}*{number3} (x*y+y*z) er {number1 * number2 + number2 * number3}");
        }

        public static void Opgave11()
        {
            int alder;

            Console.Write("Din alder: ");
            alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Du ser ældre ud end {alder}");
        }

        public static void Opgave12()
        {
            int tal;

            Console.Write("Skriv et tal: ");
            tal = Convert.ToInt32(Console.ReadLine());

            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.Write(" ");
            Console.Write(tal);
            Console.WriteLine();

            Console.Write(tal);
            Console.Write(tal);
            Console.Write(tal);
            Console.WriteLine(tal);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", tal);

            Console.WriteLine("{0}{0}{0}{0}", tal);
        }

        public static void Opgave13()
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

        public static void Opgave14()
        {
            int tal;

            Console.Write("Celsius: ");
            tal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", tal + 273);
            Console.WriteLine("Fahrenheit = {0}", tal * 18 / 10 + 32);
        }

        public static void Opgave15()
        {
            static string remove_char(string str, int n)
            {
                return str.Remove(n, 1);
            }

            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
        }

        public static void Opgave16()
        {
            static string first_last(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            }

            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
        }

        public static void Opgave17()
        {
            string str;

            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }

        public static void Opgave18()
        {

            int tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tjek om der er et positivt og negativt tal");

            if ((tal1 > 0 && tal2 < 0) || (tal1 < 0 && tal2 > 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Opgave19()
        {

            int tal1, tal2, sum;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tal1 + tal2);

            sum = tal1 + tal2;

            if (tal1 == tal2)
            {
                Console.WriteLine(sum * 3);
            }

        }

        public static void Opgave20()
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

        public static void Opgave21()
        {

            int tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet Tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 == 20 || tal2 == 20 || tal1 + tal2 == 20)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void Opgave22()
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

        public static void Opgave23()
        {

            string str;

            Console.Write("String: ");
            str = Convert.ToString(Console.ReadLine());

            Console.WriteLine(str.ToLower());
        }

        public static void Opgave24()
        {
            string str;

            Console.Write("String: ");
            str = Convert.ToString(Console.ReadLine());

            string[] ord = str.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int control = 0;

            foreach (string del in ord)
            {
                if (del.Length > control)
                {
                    word = del;
                    control = del.Length;
                }

            }
            Console.WriteLine(word);
        }

        public static void Opgave25()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Opgave26()
        {

            static bool isPrime(int n)
            {
                int x = (int)Math.Floor(Math.Sqrt(n));

                if (n == 1) return false;
                if (n == 2) return true;

                for (int i = 2; i <= x; ++i)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }

            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());
        }

        public static void Opgave27()
        {

            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }

        public static void Opgave33()
        {
            int tal1;

            Console.Write("Skriv et tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            if (tal1 > 0)
            {

                if (tal1 % 3 == 0 || tal1 % 7 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void Opgave35()
        {
            int tal1, tal2;

            Console.Write("Skriv et tal der er under 100: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv et andet tal der  over 200: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 < 100)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            if (tal2 > 200)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Opgave36()
        {
            int tal1, tal2;

            Console.Write("Skriv et tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv et andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 >= -10 && tal1 <= 10)
            {
                Console.WriteLine("True");
            }
            else if (tal2 >= -10 && tal2 <= 10)
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
