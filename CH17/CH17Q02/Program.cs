using System;
using CH17Q02;

AverageRecorder[] averageRecorders = { new AverageRecorder(), new AverageRecorder()  };

Console.Write("기록 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"\n[기록 {i+1}]");
    Console.Write("기록기 번호: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("값: ");
    int value = int.Parse(Console.ReadLine());
    averageRecorders[number].Add(value);
    Console.WriteLine($"{number}: {averageRecorders[number].GetCount()}개, 평균 {averageRecorders[number].GetAverage():F1}");
}

Console.WriteLine("최종");
Console.WriteLine($"{0}: {averageRecorders[0].GetCount()}개, 평균 {averageRecorders[0].GetAverage():F1}");
Console.WriteLine($"{1}: {averageRecorders[1].GetCount()}개, 평균 {averageRecorders[1].GetAverage():F1}");