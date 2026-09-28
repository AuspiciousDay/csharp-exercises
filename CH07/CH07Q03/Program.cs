using System;

int receiptNumber = int.Parse(Console.ReadLine());
int person = int.Parse(Console.ReadLine());

Console.WriteLine($"접수 번호: {receiptNumber++}");
Console.WriteLine($"방문순번: {++person}");
Console.WriteLine($"다음 번호: {receiptNumber}");
Console.WriteLine($"누적인원: {person}");