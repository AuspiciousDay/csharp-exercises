using System;

int n = int.Parse(Console.ReadLine());
double dbN = (double)n;
double hfDbN = dbN / 2;
string m = Convert.ToString(hfDbN);

Console.WriteLine($"숫자 타입: {hfDbN.GetType()}");
Console.WriteLine($"문자열 타입: {m.GetType()}");
Console.WriteLine($"숫자 계산: {hfDbN + 1}");
Console.WriteLine($"문자열 연결: {m + 1}");