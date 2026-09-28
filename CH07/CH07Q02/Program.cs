using System;

decimal balance = decimal.Parse(Console.ReadLine());
decimal chargeLiquid = decimal.Parse(Console.ReadLine());
decimal authorizationLiquid = decimal.Parse(Console.ReadLine());
decimal refundmentRate = decimal.Parse(Console.ReadLine());

decimal refundment = authorizationLiquid * refundmentRate / 100;

Console.WriteLine($"환불액: {refundment}");
Console.WriteLine($"최종 잔액: {balance + chargeLiquid - authorizationLiquid + refundment}");