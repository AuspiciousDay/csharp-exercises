using System;

int cheol = int.Parse(Console.ReadLine());
int yong = int.Parse((Console.ReadLine()));

Console.WriteLine($"담당자: {(cheol <= yong ? "철수" : "영희")}");
Console.WriteLine($"소요 시간: {(cheol <= yong ? cheol : yong)}");
