using System;

Console.Write("전체 칸 수: ");
int total = int.Parse(Console.ReadLine());
Console.Write("확정 칸 수: ");
int confirmation = int.Parse(Console.ReadLine());
Console.Write("대기 칸 수: ");
int wait = int.Parse(Console.ReadLine());


Console.Write("[");
Console.Write(new string('#',confirmation));
Console.Write(new string('+', wait));
Console.Write(new string('.', total - confirmation - wait));
Console.WriteLine("]");

Console.WriteLine($"빈 칸: {total - confirmation - wait}");