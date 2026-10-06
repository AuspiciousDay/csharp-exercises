using System;

Console.Write("입력 줄 수: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}번째 구간: ");
    string text = Console.ReadLine();

}



bool TryParseRange(string text, out int start, out int end)
{

}