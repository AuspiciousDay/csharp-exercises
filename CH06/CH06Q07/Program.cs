using System;

string n = Console.ReadLine();

bool isSuccess1 = int.TryParse(n, out int iResult);

Console.WriteLine($"int: {isSuccess1} / {iResult}");

bool isSuccess2 = long.TryParse(n, out long lResult);

Console.WriteLine($"long: {isSuccess2} / {lResult}");

Console.WriteLine($"성공한 변환: {Convert.ToInt32(isSuccess1) + Convert.ToInt32(isSuccess2)}");