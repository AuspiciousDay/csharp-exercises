using System;

int first = int.Parse(Console.ReadLine());
int numberInterval = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

if(n == 0)
{
    Console.WriteLine($"다음 번호: {first}");
}
else
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"발급: {first}");
        first += numberInterval;
    }
}
Console.WriteLine($"다음 번호: {first}");