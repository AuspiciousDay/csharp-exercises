using System;

int n = int.Parse(Console.ReadLine());
int discount = 0;
int count = 0;
int sum = 0;


for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number == -1)
    {
        discount++;
        continue;
    }

    sum += number;

    count++;
}

Console.WriteLine($"정상 기록: {count}");
Console.WriteLine($"제외 기록: {discount}");
Console.WriteLine($"생산량: {sum}");