using System;

Console.Write("등록 코드: ");
string code = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"원본: [{code}]");

code = code.Trim();
code = code.ToUpper();
code = code.Replace("-", "");

if (code.Length == 0)
{
    Console.WriteLine("등록 불가");
}
else
{
    Console.WriteLine($"코드: [{code.PadLeft(6, '0')}]");
}