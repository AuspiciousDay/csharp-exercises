using System;

int n = int.Parse(Console.ReadLine());
int i = 1;
int count = 0;

while (i <= n)
{
    string s = Console.ReadLine();
    if(s == "")
    {
        i++;
        continue;
    }
    else if(i == 1)
    {
        Console.Write($"메모: [{s}");
        count++;
    }
    else if(i == n)
    {
        Console.Write($", {s}]");
        count++;
    }
    else
    {
        Console.WriteLine($", {s}");
        count++;
    }
    i++;
    Console.WriteLine($"남긴 메모: {count}");
}