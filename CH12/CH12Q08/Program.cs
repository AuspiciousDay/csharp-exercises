using System;

Console.Write("묶음 최대 길이: ");
int L = int.Parse(Console.ReadLine());
Console.Write("기록 수: ");
int N = int.Parse(Console.ReadLine());

string[] main = new string[N];
string[] main2 = new string[N];
int count = 0;
int width = 0;
for(int i = 0; i < N; i++)
{
    Console.Write($"{i + 1}번 본문: ");
    main[i] = Console.ReadLine();
    count += main[i].Length;
    if(count + 8 + width  > L)
    {
        Console.Write($"묶음 {i+1} ({count + 8 + width}): ");
        for(int j = 0; j < width + 1; j++)
        {
            Console.Write($"{}");
        }
        count = 0;
        width = 0;
    }
    width++;
}

