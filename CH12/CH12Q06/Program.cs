using System;

Console.Write("묶음 수: ");
int N = int.Parse(Console.ReadLine());
int totalCount = 0;
int dCount = 0;
for (int i = 0; i < N; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[묶음 {i + 1}]");
    Console.Write($"전체 작업 수: ");
    int NCount = int.Parse(Console.ReadLine());
    totalCount += NCount;
    Console.Write($"완료 작업 수: ");
    int done = int.Parse(Console.ReadLine());
    dCount += done;
    Console.WriteLine($"{i + 1}번: {done}/{NCount} ({done / NCount:P})");
}
Console.WriteLine($"전체: {dCount}/{totalCount} ({dCount / totalCount:P})");
