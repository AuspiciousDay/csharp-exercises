using System;

Console.Write("원본 문자열: ");
string s = Console.ReadLine();

string mascked = "";
int count = 0;

foreach (char c in s)
{
    if (char.IsDigit(c))
    {
        count++;
    }
}

foreach (char c in s)
{
    if (char.IsDigit(c) && count >= 3)
    {
        mascked += "*";
        count--;
    }
    else
    {
        mascked += c;
    }
}

Console.WriteLine($"원본: [{s}]");
Console.WriteLine($"결과: [{mascked}]");
