using System;

int limit = int.Parse(Console.ReadLine());
int nCount = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
int totalCount = 0;
int discount = 0;


if (limit == 0)
{
    Console.WriteLine("적재 한도 0");
}
else
{

    for (; ; )
    {
        int weight = int.Parse(Console.ReadLine());
        sum += weight;
        count++;
        totalCount++;
        if (sum > limit)
        {
            discount++;
            sum -= weight;
            totalCount--;
            continue;
        }
        else if (sum == limit)
        {
            break;
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine($"적재 개수: {totalCount}");
    Console.WriteLine($"총무게: {sum}");
    Console.WriteLine($"제외 개수: {discount}");
    Console.WriteLine($"검사 수: {count}");

}
