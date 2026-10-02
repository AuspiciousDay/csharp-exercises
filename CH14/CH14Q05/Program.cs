using System;

Console.Write("원소 수: ");
int element = int.Parse(Console.ReadLine());
int[] n = new int[element];

for (int i = 0; i < n.Length; i++)
{
    Console.Write($"{i + 1}번째 원소: ");
    n[i] = int.Parse(Console.ReadLine());
}

Console.Write("첫 하한: ");
int fristLowerLimit = int.Parse(Console.ReadLine());
Console.Write("두 번째 하한: ");
int secondLowerLimit = int.Parse(Console.ReadLine());

Console.WriteLine($"첫 조정: [{string.Join(", ", n)}]");

RaiseBelow(n, fristLowerLimit);

Console.WriteLine($"첫 조정: [{string.Join(", ", n)}]");

RaiseBelow(n, secondLowerLimit);

Console.WriteLine($"두 번째 조정: [{string.Join(", ", n)}]");

void RaiseBelow(int[] values, int minimum)
{
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] < minimum)
        {
            values[i] = minimum;
        }
    }
}