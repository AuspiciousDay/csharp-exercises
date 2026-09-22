using System;

Console.Write("시작 위치: ");
long start = long.Parse(Console.ReadLine());

Console.Write("이동량: ");
long movementQuantity = long.Parse(Console.ReadLine());

float floatResult = (float)start + (float)movementQuantity;
double doubleResult = (double)start + (double)movementQuantity;

Console.WriteLine(floatResult - start);
Console.WriteLine(doubleResult - start);