using CH22Q05;
using System;

Console.Write("후보 수: ");
int count = int.Parse(Console.ReadLine());
int[] values = new int[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 후보 값: ");
    values[i] = int.Parse(Console.ReadLine());
}
Console.Write("목표값: ");
int target = int.Parse(Console.ReadLine());

Ranker highRanker = new Ranker(new HighPreference());
Ranker nearRanker = new Ranker(new NearPreference(target));

int highIndex = highRanker.Select(values);
int nearIndex = nearRanker.Select(values);

if (highIndex == -1)
{
    Console.WriteLine($"최대: 없음");
}
else
{
    Console.WriteLine($"최대: {highIndex}/{values[highIndex]}");
}
if (nearIndex == -1)
{
    Console.WriteLine($"근접: 없음");
}
else
{
    Console.WriteLine($"근접: {nearIndex}/{values[nearIndex]}");
}
