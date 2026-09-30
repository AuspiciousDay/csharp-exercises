using System;

int N = int.Parse(Console.ReadLine());
int[] n = new int[N];
int count = 0;
for(int i = 0; i < N; i++)
{
    int value = int.Parse(Console.ReadLine());
    n[i] = value;
}

for(int i = 0;i < N - 2; i++)
{
    if (n[i] < n[i + 1] && n[i + 1] > n[i + 2])
    {
        Console.WriteLine($"{i+1}번: {n[i+1]}");
        count++;
    }
}

Console.WriteLine($"개수: {count}");