using System;

string input = Console.ReadLine();

bool isSuccess = bool.TryParse(input, out bool result);

Console.WriteLine($"변환 성공: {isSuccess}");
Console.WriteLine($"결과값: {result}");
Console.WriteLine($"결과의 숫자 표현: {Convert.ToInt32(result)}");