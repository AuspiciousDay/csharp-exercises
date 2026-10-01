using System;

string result = null;

Console.Write("측정값: ");
double measurement = double.Parse(Console.ReadLine());
Console.Write("상한값: ");
double max = double.Parse(Console.ReadLine());


Console.WriteLine($"측정: {measurement:F1}");
Console.WriteLine($"상한: {max:F1}");

if (measurement > max)
{
    result = "초과";
}
else
{

    result = "이내";
}
Console.WriteLine($"판정: {result}");

Console.WriteLine($"여유: {(max - measurement):F3}");
