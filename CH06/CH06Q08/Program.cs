using System;

string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

bool isSuccess1 = int.TryParse(input1 , out int n1);
bool isSuccess2 = int.TryParse(input2, out int n2);

Console.WriteLine($"첫 변환: {isSuccess1} / {n1}");
Console.WriteLine($"둘째 변환: {isSuccess2} / {n2}");