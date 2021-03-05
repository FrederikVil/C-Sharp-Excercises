using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave1();
            //Opgave2();
            //Opgave3();
        }

        static void Opgave1()
        {
            int[] arr = new int[10];

            Console.WriteLine("Input 10 elements");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }

        static void Opgave2()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int arrayNumber = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrayNumber];

            Console.WriteLine($"Input {arrayNumber} number of elements in the array");

            for (int i = 0; i < arrayNumber; i++)
            {
                Console.Write($"Element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < arrayNumber; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

            Array.Reverse(arr);

            Console.Write("\nElements in array reversed are: ");
            for (int i = 0; i < arrayNumber; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            
        }

        static void Opgave3()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int arrayNumber = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrayNumber];

            Console.WriteLine($"Input {arrayNumber} number of elements in the array");

            for (int i = 0; i < arrayNumber; i++)
            {
                Console.Write($"Element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            Console.Write("\nSum of all elements stored in the array is: ");
            for (int i = 0; i < arrayNumber; i++)
            {
                sum += arr[i];             
            }
            Console.Write(sum);
            Console.Write("\n");
        }


    }
}
