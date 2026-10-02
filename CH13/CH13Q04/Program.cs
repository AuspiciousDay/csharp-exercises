using System;

Console.Write("보관 칸 이름(쉼표로 구분): ");
string s = Console.ReadLine();

string[] names = s.Split(',');
int count = 0;

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "" || names[i] == " ")
    {
        names[i] = "(비어 있음)";
        count++;
    }
}
Console.WriteLine($"칸 수: {names.Length}");
Console.WriteLine($"빈 칸: {count}");
Console.WriteLine($"보관표: [{string.Join(" | ", names)}]");