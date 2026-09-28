using System;

int n = int.Parse(Console.ReadLine());
bool isSuccess = Convert.ToBoolean(n);

int set = Convert.ToInt32(isSuccess);

Console.WriteLine($"상태: {isSuccess}");
Console.WriteLine($"표준 설정: {set}");
Console.WriteLine($"원본과 일치: {n == set}");
