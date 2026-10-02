using System;

Console.Write("원본 문장: ");
string s1 = Console.ReadLine();
Console.Write("교체 내용: ");
string s2 = Console.ReadLine();

int position1 = s1.IndexOf('[');
int position2 = s1.IndexOf(']');

Console.WriteLine($"원본: [{s1}]");

s1 = s1.Remove(position1, position2 - position1 + 1).Insert(position1, s2);


Console.WriteLine($"결과: [{s1}]");