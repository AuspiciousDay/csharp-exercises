using System;

int N = int.Parse(Console.ReadLine());

int[][] n = new int[N][];
int[] person = new int[N];
int[] sum = new int[N];

for (int i = 0; i < N; i++)
{
    int Ncount = int.Parse(Console.ReadLine());
    n[i] = new int[Ncount];
    if (Ncount == 0)
    {
        continue;
    }
    for (int j = 0; j < Ncount; j++)
    {
        int value = int.Parse(Console.ReadLine());
        person[j]++;
        sum[j] += value;
        n[i][j] = value;
    }
}

int totalSum = 0;

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"{i + 1}회차: {person[i]}명, 합계 {sum[i]}");
    totalSum += person[i];
}
Console.WriteLine($"전체 기록: {totalSum}");
