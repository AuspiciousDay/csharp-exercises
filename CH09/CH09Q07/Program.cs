using System;

int n = int.Parse(Console.ReadLine());
int count = 0;
if(n== 0)
{
    Console.WriteLine("측정 없음");
}
else
{
    int fNumber = int.Parse(Console.ReadLine());
    int max = fNumber;
    Console.WriteLine($"기록 갱신: {max}");
    count++;

    for (int i = 1; i < n; i++)
    {
        int number = int.Parse(Console.ReadLine());
        if (number > max)
        {
            max = number;
            Console.WriteLine($"기록 갱신: {max}");
            count++;
        }
    }
    Console.WriteLine($"최고 기록: {max}");
    Console.WriteLine($"갱신 횟수: {count}");
}
