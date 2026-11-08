using System;
using System.Globalization;
using CH21Q02;

Console.Write("이름: ");
string name = Console.ReadLine();
Console.Write("전체 단계 수: ");
int total = int.Parse(Console.ReadLine());

ProgressTask progressTask = new ProgressTask(name, total);

Console.WriteLine(progressTask);
string text = progressTask.ToString();
Console.Write("진행 요청 수: ");
int count = int.Parse(Console.ReadLine());
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 진행량: ");
    int taskCount = int.Parse(Console.ReadLine());
    Console.WriteLine($"{progressTask.Advance(taskCount)}: {progressTask}");
}
Console.WriteLine($"초기 저장: {text}");