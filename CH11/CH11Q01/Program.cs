using System;

int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());

int[] n = new int[N];

for (int i = 0; i < M; i++)
{
    int numberN = int.Parse(Console.ReadLine());
    int numberM = int.Parse(Console.ReadLine());
    n[numberN - 1] += numberM;
}

int sum = 0;
int count = 0;

foreach (int total in n)
{
    count++;
    sum += total;
    Console.WriteLine($"{count}번: {total}");
}
Console.WriteLine($"전체: {sum}");

