using System;

int n = int.Parse(Console.ReadLine());

int totalCount = 0;
int end = 0;
for(int i = 1; i <= n; i++)
{
    int sum = 0;
    int count = 0;
    for (; ; )
    {
        int nCount = int.Parse(Console.ReadLine());
        
        if (nCount == 0)
        {
            end ++;
            break;
        }
        else if (nCount == -1)
        {
            continue;
        }
        else
        {
            totalCount++;
            sum += nCount;
            count++;
        }
        
    }
    Console.WriteLine($"묶음 {i}: {count}건 / {sum}개");
    if (end == n)
    {
        break;
    }
    
}
Console.WriteLine($"전체 수량: {totalCount}");
