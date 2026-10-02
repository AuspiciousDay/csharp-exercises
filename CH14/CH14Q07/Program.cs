using System;

Console.Write("사용자명 수: ");
int userCount = int.Parse(Console.ReadLine());

string[] s = new string[userCount];

for(int i = 0; i < userCount; i++)
{
    Console.Write($"{i+1}번째 사용자명: ");
    s[i] = Console.ReadLine();
    
}

bool IsValidName(string text)
{
    return true;
}