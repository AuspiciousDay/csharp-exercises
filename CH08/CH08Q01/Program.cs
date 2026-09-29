using System;

int temperature = int.Parse(Console.ReadLine());
int humidity = int.Parse(Console.ReadLine());

int n = 0;

if(temperature > 30)
{
    Console.WriteLine("온도 경고");
    n++;
}

if(humidity > 70)
{
    Console.WriteLine("습도 경고");
    n++;
}

Console.WriteLine($"경고 수: {n}");
