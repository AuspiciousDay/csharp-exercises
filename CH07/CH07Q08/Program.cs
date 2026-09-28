using System;

int number = int.Parse(Console.ReadLine());
int move = int.Parse(Console.ReadLine());

int choice = move >= 0 ? (number + move) % 8 : (number + move % 8 + 8) % 8;

Console.WriteLine($"선택 칸: {choice}");
Console.WriteLine($"경계 통과: {number + move <= 0 || number + move > 7 }");