using System;

Console.Write("점수 입력: ");
string score = Console.ReadLine();
string[] strings = score.Split(' ');
int[] scores = new int[strings.Length];
for (int i = 0; i < strings.Length; i++)
{
    scores[i] = int.Parse(strings[i]);
}

Console.Write($"입력한 점수: ");
MyArray.ForEach(scores, n => Console.Write($"{n}점 "));

Console.Write($"\n60점 이상 인원: {MyArray.Count(scores, n => n >= 60)}명");

Console.Write($"\n만점 존재 여부: {MyArray.Exists(scores, n => n == 100)}");

Console.Write($"\n첫 90점 이상 위치: {MyArray.FindIndex(scores, n => n >= 90)}");

int[] passed = MyArray.Filter(scores, n => n >= 60);
Console.Write($"\n60점 이상 점수: [");
for (int i = 0; i < passed.Length; i++)
{
    Console.Write($"{passed[i]}");
    if (i != passed.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write($"]");

Console.Write($"\n짝수 점수: [");
for (int i = 0; i < MyArray.Filter(scores, IsEven).Length; i++)
{
    Console.Write($"{MyArray.Filter(scores, IsEven)[i]}");
    if (i != MyArray.Filter(scores, IsEven).Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write($"]");

MyArray.Transform(passed, n => Math.Min(n + 5, 100));
Console.Write($"\n보정 점수: [");
for (int i = 0; i < passed.Length; i++)
{
    Console.Write($"{passed[i]}");
    if (i != passed.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write($"]");


Console.Write($"\n보정 점수 내림차순: [");
for (int i = 0; i < MyArray.Sort(passed, (x, y) => y.CompareTo(x)).Length; i++)
{
    Console.Write($"{MyArray.Sort(passed, (x, y) => y.CompareTo(x))[i]}");
    if (i != MyArray.Sort(passed, (x, y) => y.CompareTo(x)).Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write($"]");

static bool IsEven(int n)
{
    return n % 2 == 0;
}
