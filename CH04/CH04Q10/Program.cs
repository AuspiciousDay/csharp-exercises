using System;

Console.Write("원단 전체 길이: ");
decimal wholLen = decimal.Parse(Console.ReadLine());

Console.Write("제품 한 개에 들어가는 원단 길이: ");
double len = double.Parse(Console.ReadLine());

Console.Write("주문 수량: ");
int ordrQty = int.Parse(Console.ReadLine());

const decimal charge = 12.50m;

Console.WriteLine($"\n처리 수량: {Math.Floor(wholLen / (decimal)(len + 0.1))}");
Console.WriteLine($"미처리 수량: {ordrQty - Math.Floor(wholLen / (decimal)(len + 0.1))}");
Console.WriteLine($"남은 원단: {wholLen - Math.Floor(wholLen / (decimal)(len + 0.1)) * (decimal)(len + 0.1):F1}m");
Console.WriteLine($"판매액: {charge * Math.Floor(wholLen / (decimal)(len + 0.1)):F2}");
