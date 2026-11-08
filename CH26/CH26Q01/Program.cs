using CH26Q01;
using System;

Console.Write("정수 개수: ");
int count = int.Parse(Console.ReadLine());

int[] ints = new int[count];
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 정수: ");
    ints[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"폭: {}");
Console.WriteLine($"변화: {}");

