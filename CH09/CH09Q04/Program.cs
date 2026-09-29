using System;

int total = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int count = 0;
int n = total;
if(total == 0)
{
    Console.WriteLine("물품 없음");
}
else
{
    for(int i = 0; i < total % max; i++)
    {
        count++;
        Console.WriteLine($"{count}회: {max}개 / 남음: {n -= max}");
    }
    if(total % max != 0)
    {
        count++;
        Console.WriteLine($"{count}회: {total % max}개 / 남음: {Math.Max(n -= max, 0)}");
    }
}
Console.WriteLine($"포장 횟수: {count}");