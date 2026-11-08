using System;

Console.Write("사용자명 수: ");
int userCount = int.Parse(Console.ReadLine());

string[] s = new string[userCount];
int count = 0;
string result = "";
for(int i = 0; i < userCount; i++)
{
    Console.Write($"{i+1}번째 사용자명: ");
    s[i] = Console.ReadLine();

    if (IsValidName(s[i]))
    {
        result = "허용";
        Console.WriteLine($"[{s[i]}]: {result}");
        count++;
    }
    else
    {
        result = "거부";
        Console.WriteLine($"[{s[i]}]: {result}");
    }
}
Console.WriteLine($"허용 수: {count}");


bool IsValidName(string text)
{

    if(text.Length > 2 && text.Length < 9 && 
        char.IsLetter(text[0]))
    {
        for (int i = 1; i < text.Length; i++)
        {
            if(char.IsLetter(text[i]) || char.IsDigit(text[i]) 
                || text[i] == '_')
            {
                return true;
            }
            return false;
        }

        
    }
    return false;
}