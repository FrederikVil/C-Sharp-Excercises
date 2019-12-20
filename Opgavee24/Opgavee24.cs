using System;

namespace Opgavee24
{
    class Opgavee24
    {
        static void Main(string[] args)
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
    }
}
