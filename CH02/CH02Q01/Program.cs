using System;

class Program
{
    static void Main()
    {
        Console.Write($"18 + 3 = {18 + 3}\n");
        Console.Write($"18 - 3 = {18 - 3}\n");
        Console.Write($"18 * 3 = {18 * 3}\n");
        Console.Write($"18 / 3 = {18 / 3}\n");

        

        Console.WriteLine("\n문자열 연결: " + "18 + 3 = " + (18 + 3));
        Console.WriteLine($"문자열 보간: 18 + 3 = {18 + 3}");

    }
}