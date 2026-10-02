using System;

Console.Write("초기 잔액: ");
int beginningBalance = int.Parse(Console.ReadLine());
Console.Write("조정액: ");
int adjustmentLiquid1 = int.Parse(Console.ReadLine());
Console.Write("두 번째 조정액: ");
int adjustmentLiquid2 = int.Parse(Console.ReadLine());

Console.WriteLine($"초기: {beginningBalance}");
Console.WriteLine($"첫 조정 후: {ApplyChange(beginningBalance, adjustmentLiquid1)}");
Console.WriteLine($"최종: {ApplyChange(ApplyChange(beginningBalance, adjustmentLiquid1), adjustmentLiquid2)}");

int ApplyChange(int current, int change)
{
    current += change;

    if (current <= 0)
    {
        return current = 0;
    }

    return current;
}