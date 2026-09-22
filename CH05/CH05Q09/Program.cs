using System;

Console.Write("이전 지침: ");
double before = double.Parse(Console.ReadLine());

Console.Write("현재 지침: ");
double now = double.Parse(Console.ReadLine());

Console.Write("단위당 요금: ");
decimal charge = decimal.Parse(Console.ReadLine());

Console.WriteLine($"총 사용량: {now - before}");
Console.WriteLine($"과금 사용량: {(now - before) % 10}");

decimal money = charge * (decimal)((now - before) % 10);

Console.WriteLine($"정산 금액: {money:F2}");