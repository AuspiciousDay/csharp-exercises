using System;

int commodityCount = int.Parse(Console.ReadLine());
int bundleCount = int.Parse(Console.ReadLine());

Console.WriteLine($"나누기 가능: {commodityCount % bundleCount == 0}");