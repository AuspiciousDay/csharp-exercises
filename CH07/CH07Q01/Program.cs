using System;

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

double line1 = n1 / n2 + 1;
double line2 = n1 % n2;

Console.WriteLine($"행: {line1}");
Console.WriteLine($"열: {line2}");