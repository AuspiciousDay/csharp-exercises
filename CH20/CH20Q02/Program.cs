using CH20Q02;
using System;

Console.Write("기록 용량: ");
int capacity = int.Parse(Console.ReadLine());
Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());
PositiveRecorder positiveRecorder = new PositiveRecorder(capacity);

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 기록값: ");
    int value = int.Parse(Console.ReadLine());
    Console.WriteLine($"{positiveRecorder.Record(value)}: {positiveRecorder.Count}개 {positiveRecorder.Describe()}");
}

Console.WriteLine($"최종 : {positiveRecorder.Describe()} / 용량 {positiveRecorder.Capacity}");
