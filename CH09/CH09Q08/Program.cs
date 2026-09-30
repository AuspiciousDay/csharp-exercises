using System;

int count = int.Parse(Console.ReadLine());
int fNumber = int.Parse(Console.ReadLine());
int max = fNumber;
int up = 0;
int maxUp = 0;
if (count > 1)
{
    for (int i = 1; i < count; i++)
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= max)
        {
            up = 0;
        }
        else
        {
            up++;
            max = number;
            if (up > maxUp)
            {
                maxUp = up;
            }
        }
    }
}
Console.WriteLine($"최장 연속 상승: {maxUp}");
