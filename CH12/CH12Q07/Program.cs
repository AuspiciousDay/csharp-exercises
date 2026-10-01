using System;

Console.Write("초기 포인트: ");
int points = int.Parse(Console.ReadLine());
Console.Write("변경 횟수: ");
int count = int.Parse(Console.ReadLine());

string[] history = new string[count];
string format = "{0:D2} {1} -> {2} (요청: {3}, 반영{4})";

for(int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번 변경 요청량: ");
    int requested = int.Parse(Console.ReadLine());
    int before = points;
    points = Math.Clamp(points +  requested, 0, 100);
    int applied = points - before;
    history[i] = string.Format(format,i+1,before,points, requested,applied);
}

Console.WriteLine($"최종: {points}");
foreach(string line in history)
{
    Console.WriteLine(line);
}
