using System;

int raw = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());

int[,] n = new int[raw, col];

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        n[i, j] = int.Parse(Console.ReadLine());
    }
}

int[,] m = new int[col, raw];

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        m[j, i] = n[i, j];
    }
}

for (int i = 0; i < m.GetLength(0); i++)
{
    for (int j = 0; j < m.GetLength(1); j++)
    {
        Console.Write($"{m[i, j]} ");
    }
    Console.WriteLine();
}
