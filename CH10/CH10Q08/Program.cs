using System;

int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
int count = 0;
int n1 = 0;
int n2 = 0;

for(int i = 1; i <= row; i++)
{
    for(int j = 1; j <= col; j++)
    {
        int use = int.Parse(Console.ReadLine());
        if(use == 0)
        {
            count++;
            n1 = i;
            n2 = j;
            break;
        }
        count++;
    }
    if(n1 != 0)
    {
        break;
    }
}
Console.WriteLine($"빈 좌석: {n1}행 {n2}열");
Console.WriteLine($"검사 칸: {count}");
