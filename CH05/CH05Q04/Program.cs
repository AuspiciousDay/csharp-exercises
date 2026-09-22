using System;

Console.Write("완료 작업 수: ");
int completionJobCount = int.Parse(Console.ReadLine());

Console.Write("전체 작업 수: ");
int wholeJobCount = int.Parse(Console.ReadLine());

Console.WriteLine($"진행 비율: {(double)completionJobCount / wholeJobCount}");
Console.WriteLine($"정수 백분율: {Math.Floor((double)completionJobCount / wholeJobCount * 100)}%");