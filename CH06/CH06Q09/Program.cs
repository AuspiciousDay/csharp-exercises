using System;

int code = Console.Read();
Console.ReadLine();
char c = (char)code;

int ch = int.Parse(Console.ReadLine());

Console.WriteLine($"수량: {c}개");
Console.WriteLine($"결제액: {c * ch}원");