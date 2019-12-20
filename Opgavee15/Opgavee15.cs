using System;
using System.Collections.Generic;

public class Opgavee15
{
    static void Main()
    {
        Console.WriteLine(remove_char("w3resource", 1));
        Console.WriteLine(remove_char("w3resource", 9));
        Console.WriteLine(remove_char("w3resource", 0));
    }
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}