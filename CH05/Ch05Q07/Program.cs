using System;

Console.Write("십의 자리: ");
char num10 = char.Parse(Console.ReadLine());

Console.Write("일의 자리: ");
char num1 = char.Parse(Console.ReadLine());

Console.WriteLine($"번호 표기: {num10}{num1}");

Console.WriteLine($"정수 값: {num10 - '0' + num1 - '0'}");
