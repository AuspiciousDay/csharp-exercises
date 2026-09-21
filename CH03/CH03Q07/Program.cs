using System;

int 철수 = int.Parse(Console.ReadLine());
int 영희 = int.Parse(Console.ReadLine());

Console.WriteLine($"교환 전: 철수 {철수} / 영희 {영희}");
int ch = 철수;
철수 = 영희;
영희 = ch;
Console.WriteLine($"교환 후: 철수 {철수} / 영희 {영희}");