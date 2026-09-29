using System;

int count = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < count; i++)
{
    int value = int.Parse(Console.ReadLine());
    sum += value;
}

if (count == 0)
{
    Console.WriteLine("측정 없음");
}
else
{
    Console.WriteLine($"합계 {sum}");
    double average = (double)sum / count;
    average = Math.Round(average, 2);
    Console.WriteLine($"평균: {average}");
}