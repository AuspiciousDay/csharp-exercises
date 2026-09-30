using System;

int N = int.Parse(Console.ReadLine());

int[] n = new int[N];

for(int i = 0; i < N; i++)
{
    int Nnumber = int.Parse(Console.ReadLine());
    n[i] = Nnumber;
}

for(int i = 0; i < N / 2; i++)
{
    int temp = n[i];

    n[i] = n[n.Length - i - 1];

    n[n.Length - i - 1] = temp;
}
Console.Write("목록: ");

foreach(int number in n)
{
    Console.Write($"{number} ");
}

