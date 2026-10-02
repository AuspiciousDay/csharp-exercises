using System;

Console.Write("상품 종류 수: ");
int count = int.Parse(Console.ReadLine());

int[] prices = new int[count];
int[] quantities = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[상품 {i + 1}]");
    Console.Write("단가: ");
    prices[i] = int.Parse(Console.ReadLine());
    Console.Write("수량: ");
    quantities[i] = int.Parse(Console.ReadLine());
}

Console.Write("방문 수령 여부: ");
bool pickup = bool.Parse(Console.ReadLine());

decimal subtotal = GetSubtotal(prices, quantities);
decimal ratePayable = GetPayable(subtotal, "정률", pickup);
decimal fixedPayable = GetPayable(subtotal, "정액", pickup);

Console.WriteLine($"상품 합계: {subtotal}");
Console.WriteLine($"정률 합계: {ratePayable}");
Console.WriteLine($"정액 합계: {fixedPayable}");
Console.WriteLine($"선택: {(ratePayable < fixedPayable ? "정률" : "정액")}");

decimal GetSubtotal(int[] prices, int[] quantities)
{
    decimal total = 0;
    for (int i = 0; i < prices.Length; i++)
    {
        total += prices[i] * quantities[i];
    }
    return total;
}

decimal GetDiscount(decimal subtotal, string coupon)
{
    switch (coupon)
    {
        case "정률":
            return subtotal * 0.1m;
        case "정액":
            return subtotal >= 10000 ? 2000 : 0;
        default:
            break;
    }
    return 0;
}

decimal GetShipping(decimal afterDiscount, bool pickup = false)
{
    if (pickup || afterDiscount == 0 || afterDiscount >= 20000)
    {
        return 0;
    }
    return 3000;
}

decimal GetPayable(decimal subtotal, string coupon, bool pickup)
{
    decimal afterDiscount = subtotal - GetDiscount(subtotal, coupon);
    return afterDiscount + GetShipping(afterDiscount, pickup);
}
