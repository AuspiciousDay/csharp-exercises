using System;

int N = int.Parse(Console.ReadLine());

string[] Name = new string [N];
int[] Score = new int[N];
int[] Retry = new int[N];
int[] difference = new int[N];

for (int i = 0; i < N; i++)
{
    string name = Console.ReadLine();
    int score = int.Parse(Console.ReadLine());
    int retry = int.Parse(Console.ReadLine());

    Name[i] = name;
    Score[i] = score;
    Retry[i] = retry;
}

for(int i = 0;i < N; i++)
{
    difference[i] = Retry[i] - Score[i];
}
int max = difference[0];
for(int i = 0;i<N ; i++)
{
    if (difference[i] > 0)
    {
        Console.WriteLine($"{Name[i]}: +{difference[i]}");
    }
    if(max < difference[i])
    {
        max = difference[i];
    }
}
Console.Write("최고 향상: ");
for(int i = 0; i < N; i++)
{
    if (difference[i] == max)
    {
        Console.Write($"{Name[i]} ");
    }
}
Console.WriteLine();
