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
            //Opgave4();
            //Opgave5();
            //Opgave6();
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
        
        static void Opgave4()
        {
            int[] arr = { 1, 3, 7, 4, 5 };
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];               
            }

            Console.Write("Original array: ");
            foreach (int n in arr)
            {
                Console.Write(n);
            }

            Console.Write("\nCopied array: ");
            foreach (int n in newArr)
            {
                Console.Write(n);
            }
        }

        static void Opgave5()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int s1, mm = 1, ctr = 0;
            int i, j;
            Console.Write("\n\nCount total number of duplicate elements in an array:\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < s1; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            for (i = 0; i < s1; i++)
            {
                for (j = 0; j < s1; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }

            for (i = 0; i < s1; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);

            Console.Write("\n\n");
        }
        
        static void Opgave6()
        {         
            Console.Write("Input the number of elements to be stored in the array :");
            int arrayNumber = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrayNumber];

            Console.WriteLine($"Input {arrayNumber} number of elements in the array");
            int i, j, count, uniqueCounter = 0;
            for (i = 0; i < arrayNumber; i++)
            {
                Console.Write($"Element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                count = 0;

                for (j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count == 1)
                {
                    uniqueCounter++;
                }
            }
            Console.WriteLine("The amount of unique numbers in the array are: " + uniqueCounter);
        }


    }
}
