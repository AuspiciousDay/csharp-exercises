using System;

Console.Write("첫 요청 문자: ");
char c1 = char.Parse(Console.ReadLine());
Console.Write("첫 요청 행 수: ");
int raw1 = int.Parse(Console.ReadLine());
Console.Write("두 번째 요청 문자: ");
char c2 = char.Parse(Console.ReadLine());
Console.Write("두 번째 요청 행 수: ");
int raw2 = int.Parse(Console.ReadLine());

PrintSteps(c1, raw1);
PrintSteps(c2, raw2);

void PrintSteps(char symbol, int rows)
{
    if (rows < 0)
    {
        Console.WriteLine("출력 없음");
        return;
    }
    for (int i = 1; i <= rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write($"{symbol}");
        }
        Console.WriteLine();
    }
}