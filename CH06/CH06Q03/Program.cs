using System;

double number = double.Parse(Console.ReadLine());

int convertNumber = Convert.ToInt32(number);

Console.WriteLine($"Convert 좌표: {convertNumber}");
Console.WriteLine($"캐스트 좌표: {(int)number}");
Console.WriteLine($"좌표 차이: {convertNumber - (int)number}");