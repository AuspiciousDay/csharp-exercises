using System;

int N = int.Parse(Console.ReadLine());
int[] n = new int[N];
int count = 0;

for(int i = 0; i < N; i++)
{
    int fCount = int.Parse(Console.ReadLine());
    n[i] = fCount;
    count += fCount;
}

int move = int.Parse(Console.ReadLine());

for(int i = 0;i < move; i++)
{
    int start = int.Parse(Console.ReadLine());
    int end = int.Parse(Console.ReadLine());
    int moveCount = int.Parse(Console.ReadLine());
    if(start == end)
    {
        Console.WriteLine("요청 오류");
        continue;
    }
    else if(moveCount > n[start - 1])
    {
        Console.WriteLine("재고 부족");
        continue;
    }
    else if((start > N || start < 0) && (end > N || end < 0))
    {
        Console.WriteLine("요청 오류");
        continue;
    }
    else
    {
        n[start - 1] -= moveCount;
        n[end - 1] += moveCount;
        Console.WriteLine("이동 완료");
    }

}
for(int i = 0; i < N; i++)
{
    Console.WriteLine($"{i+1}번: {n[i]}");
}
Console.WriteLine($"전체: {count}");