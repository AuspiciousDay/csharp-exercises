using CH22Q02;
using System;

Console.Write("요청수: ");
int count = int.Parse(Console.ReadLine());

SessionCounter sessionCounter = new SessionCounter();
ISession session = sessionCounter;
ILifetime lifetime = sessionCounter;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string action = Console.ReadLine();
    if (action == "추가")
    {
        Console.Write("추가할 값: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine($"추가 {sessionCounter.Add(value)}: {sessionCounter.Sum}/{sessionCounter.TotalSum}");
    }
    else if (action == "회차초기화")
    {
        lifetime.Reset();
        Console.WriteLine($"회차초기화: {sessionCounter.Sum}/{sessionCounter.TotalSum}");
    }
    else if (action == "누적초기화")
    {
        session.Reset();
        Console.WriteLine($"누적초기화: {sessionCounter.Sum}/{sessionCounter.TotalSum}");
    }
}
Console.WriteLine($"최종: {sessionCounter.Sum}/{sessionCounter.TotalSum}");