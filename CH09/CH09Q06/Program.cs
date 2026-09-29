using System;

int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
int count = 0;
if (row == 0)
{
    Console.WriteLine("격자 줄 없음");
}
else
{
    for (int i = 0; i < row; i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < col; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                    count++;
                }
            }
        }
        else
        {
            for (int j = 0; j < col; j++)
            {
                if (j % 2 == 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                    count++;
                }
            }
        }
        
        Console.WriteLine();
    }
    Console.WriteLine($"# 개수: {count}");
}
