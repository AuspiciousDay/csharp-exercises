using System;

Console.Write("첫째 보상액: ");
float frAmnt = float.Parse(Console.ReadLine());

Console.Write("둘째 보상액: ");
float scAmnt = float.Parse(Console.ReadLine());

int A = (int)Math.Round(frAmnt) + (int)Math.Round(scAmnt);

int B = (int)Math.Round(frAmnt + scAmnt);

int dffr = Math.Abs(A - B);

Console.WriteLine($"\n건별 정산: {A}");
Console.WriteLine($"합산 정산: {B}");
Console.WriteLine($"차이: {dffr}");