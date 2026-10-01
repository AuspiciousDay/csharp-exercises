using System;
using static System.Net.Mime.MediaTypeNames;

Console.Write("원본 문장: ");
string s1 = Console.ReadLine();
Console.Write("교체 내용: ");
string s2 = Console.ReadLine();

int position1 = s1.IndexOf('[');
int position2 = s1.IndexOf(']');

Console.WriteLine($"원본: [{s1}]");

s1 = s1.Substring(position1, position2 - position1 + 1);

Console.WriteLine($"결과: [{}]");