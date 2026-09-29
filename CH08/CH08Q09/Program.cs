using System;

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int count = 0;

if (start > end)
{
    Console.WriteLine("잘못된 순서");
}
else if (start < 0)
{
    if (end > 0 || end < 100)
    {
        count = start + end;
        Console.WriteLine($"출력 범위: {0}~{end}");
        Console.WriteLine($"출력 장수: {end}");
        Console.WriteLine($"제외된 장수: {Math.Abs(count)}");

    }
    else
    {
        Console.WriteLine("출력할 페이지 없음");
    }
}
else if (start > 100)
{
    Console.WriteLine("출력할 페이지 없음");
}
else
{
    if (end > 100)
    {
        count = end - 100;
        Console.WriteLine($"출력 범위: {start}~{100}");
        Console.WriteLine($"출력 장수: {101 - start}");
        Console.WriteLine($"제외된 장수: {Math.Abs(count)}");

    }
}



