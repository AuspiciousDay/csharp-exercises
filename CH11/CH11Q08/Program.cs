using System;

int N = int.Parse(Console.ReadLine());
string[] n = new string[N];

for(int i = 0; i < N; i++)
{
    string name = Console.ReadLine();
    n[i] = name;
}

int count = int.Parse(Console.ReadLine());

Console.Write("원본: ");
foreach(string i in n)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

for(int i = 0;i < count; i++)
{
    string temp = n[0];
    for(int j = 0; j < N -1; j++)
    {
        n[j] = n[j+1];
    }
    n[n.Length -1] = temp;
}

Console.Write("변경: ");
foreach (string i in n)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
