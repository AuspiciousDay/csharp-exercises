using System;

Console.Write("첫번째 접수 번호: ");
string num1Text = Console.ReadLine();

Console.Write("두번째 접수 번호: ");
string num2Text = Console.ReadLine();

Console.WriteLine($"\n원문: [{num1Text}] / [{num2Text}]");
Console.WriteLine($"같은 표기: {num1Text == num2Text}");

int num1 = int.Parse( num1Text );
int num2 = int.Parse(num2Text );

bool same = num1 == num2;

Console.WriteLine($"같은 번호: {num1 == num2}");

