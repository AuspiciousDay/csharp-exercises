using System;

Console.Write("소수 좌표: ");
decimal num = decimal.Parse(Console.ReadLine());

Console.WriteLine($"원본: {num}");
Console.WriteLine($"정수 좌표: {(int)num}");
Console.WriteLine($"잔여 이동: {num - (int)num}");
