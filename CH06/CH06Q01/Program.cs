using System;

Char ch = Convert.ToChar(Console.ReadLine());
Char ntCh = (char)(ch + 1);

Console.WriteLine($"다음 구역: {ntCh}");
Console.WriteLine($"코드 차이: {ntCh - ch}");