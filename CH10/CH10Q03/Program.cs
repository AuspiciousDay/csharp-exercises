using System;

int limit = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
int exclusion = 0;

for (; ; )
{
    int weight = int.Parse(Console.ReadLine());

    sum += weight;
    count++;

    if (sum > limit)
    {
        exclusion++;
        sum -= weight;
        break;
    }

}

Console.WriteLine($"적재 개수: {count - exclusion}");
Console.WriteLine($"총무게: {sum}");
Console.WriteLine($"중단 물품: {exclusion}");

