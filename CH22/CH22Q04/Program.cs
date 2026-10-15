using CH22Q04;
using System;


Console.Write("값 개수: ");
int count = int.Parse(Console.ReadLine());
int[] values = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 값: ");
    values[i] = int.Parse(Console.ReadLine());
}

ArrayReader arrayReader = new ArrayReader(values);
IIntReader intReader = arrayReader;
IResettable resettable = arrayReader;
IReplayReader replayReader = arrayReader;

Console.Write("요청 수: ");
count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 동작: ");
    string action = Console.ReadLine();
    if (action == "읽기")
    {
        Console.WriteLine($"{intReader.TryRead(out int value)}: {value}, 위치 {replayReader.Position}");
    }
    else if (action == "초기화")
    {
        arrayReader.Reset();
        Console.WriteLine($"초기화: 위치 {replayReader.Position}");
    }
}

Console.WriteLine($"최종 위치: {replayReader.Position}");