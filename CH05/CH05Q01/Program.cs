using System;

Console.Write("구역 순번: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("좌석 번호: ");
int num2 = int.Parse(Console.ReadLine());

num1 += 64;

Console.WriteLine($"좌석: {(char)num1} - {num2}");