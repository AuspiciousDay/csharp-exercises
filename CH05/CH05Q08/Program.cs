using System;

Console.Write("전체 금액: ");
decimal money = decimal.Parse(Console.ReadLine());

Console.Write("인원수: ");
int people = int.Parse(Console.ReadLine());

int give = (int)money / people;

Console.WriteLine($"1인당 지급: {give}원");
Console.WriteLine($"총 지급: {give * people}원");
Console.WriteLine($"남은 금액: {money - give * people}원");