using System;

int n = int.Parse(Console.ReadLine());
int count = 0;
string memo  = string.Empty;

for(int i =0; i < n; i++)
{
    string s = Console.ReadLine();
    if(s == "")
    {
        continue;
    }
    count++;
    memo += ((count == 1) ? s : ", " + s);
    
}

Console.WriteLine($"메모:[{memo}]");
Console.WriteLine($"남긴 메모: {count}");
