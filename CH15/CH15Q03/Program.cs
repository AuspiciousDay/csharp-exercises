using System;

Console.Write("입력 줄 수: ");
int input = int.Parse(Console.ReadLine());

for(int i = 0; i < input; i++)
{
    Console.Write($"{i + 1}번째 구간: ");
    string text = Console.ReadLine();
    Console.WriteLine($"{TryParseRange(text, out int start, out int end)}: {start}, {end}");
    if (TryParseRange(text, out start, out end))
    {
        int count = end - start + 1;
        Console.WriteLine($"개수: {count}");
    }

}



bool TryParseRange(string text, out int start, out int end)
{
    string[] texts = text.Split(':');
    if(int.TryParse(texts[0], out start) &&
       int.TryParse(texts[1], out end)&&
       start >= 0 && start <= 100 && 
       end <= 100 && start <= end)
    {
        return true;
    }
    start = 0;
    end = 0;
    return false;

}