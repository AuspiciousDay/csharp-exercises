using System;

Console.Write("상품 단가: ");
decimal goodsUnitPrice = decimal.Parse(Console.ReadLine());

Console.Write("구매 수량: ");
int purchaseQuantity = int.Parse(Console.ReadLine());

Console.Write("할인율: ");
float discountRate = float.Parse(Console.ReadLine());

decimal settlementLiquid = goodsUnitPrice * purchaseQuantity * (decimal)(1 - discountRate);
decimal earnLiquid = settlementLiquid * (decimal)0.02;

Console.WriteLine($"\n결제액: {Math.Round(settlementLiquid, 2)}");
Console.WriteLine($"적립액: {Math.Round(earnLiquid, 2)}");