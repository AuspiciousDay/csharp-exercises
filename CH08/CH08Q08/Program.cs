using System;

string set = Console.ReadLine();
string file = Console.ReadLine();

int setting = 0;
string fileSet;

if(!int.TryParse(set, out int n) || n < 0 || n > 100)
{
    if(!int.TryParse(file, out n) ||  n < 0 || n > 100)
    {
        setting = 20;
        fileSet = "기본값";
    }
    else
    {
        setting = n;
        fileSet = "파일";
    }
}
else
{
    setting = n;
    fileSet = "명령줄";
}

Console.WriteLine($"출처: {fileSet}");
Console.WriteLine($"설정값: {setting}");
