using System;

int n = int.Parse(Console.ReadLine());
int result = 1;

if(n == 0)
{
    Console.WriteLine($"합성배율: {result}");
}
else
{
    for (int i = 0; i < n; i++)
    {
        int m = int.Parse(Console.ReadLine());
        result *= m;
    }

    Console.WriteLine($"합성 배율: {result}");
}
