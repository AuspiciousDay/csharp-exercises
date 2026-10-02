using System;

Console.Write("주문 A 수량: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("주문 B 수량: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("묶음당 수량: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine($"개별 포장: {GetBundleCount(n1, count) + GetBundleCount(n2, count)}");
Console.WriteLine($"합동 포장: {GetBundleCount(n1 + n2, count)}");
Console.WriteLine($"줄어든 묶음: {GetBundleCount(n1, count) + GetBundleCount(n2, count) - GetBundleCount(n1 + n2, count)}");



int GetBundleCount(int amount, int capacity)
{
    if (capacity < 1)
    {
        return 0;
    }
    if (amount < capacity)
    {
        return 1;
    }
    else
    {
        return amount / capacity;
    }
}