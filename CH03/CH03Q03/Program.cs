using System;

int 시작점수 = int.Parse(Console.ReadLine());
int 획득점수 = int.Parse(Console.ReadLine());
int 차감점수 = int.Parse(Console.ReadLine());

Console.WriteLine($"시작: {시작점수}");
Console.WriteLine($"획득 후: {시작점수 + 획득점수}");
Console.WriteLine($"차감 후: {시작점수 + 획득점수 - 차감점수}");