using System;

int findCount = int.Parse(Console.ReadLine());
int targetCount = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i <= findCount; i++)
{
    int target = int.Parse(Console.ReadLine());

    if (target == targetCount)
    {
        count++;
        Console.WriteLine($"첫 위치: {count}");
        Console.WriteLine($"검사 수: {count}");
        break;
    }

    if (i == findCount)
    {
        Console.WriteLine("상품 없음");
    }
    count++;
}

