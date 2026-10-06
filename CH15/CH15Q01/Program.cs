using System;

Console.Write("정수: ");
int i = int.Parse(Console.ReadLine());
Console.Write("실수: ");
double f = double.Parse(Console.ReadLine());

Console.WriteLine($"정수: {Limiter.Clamp(i)}");
Console.WriteLine($"실수: {Limiter.Clamp(f):F2}");
Console.WriteLine($"혼합: {Limiter.Clamp(i , 0.0 , 2.5):F2}");

public static class Limiter
{
    public static int Clamp(int value, int minimum = 0, int maximum = 10)
    {
        return Math.Clamp(value, minimum, maximum);
    }
    public static double Clamp(double value, double minimum = 0, double maximum = 10)
    {
        return Math.Clamp(value, minimum, maximum);
    }
}