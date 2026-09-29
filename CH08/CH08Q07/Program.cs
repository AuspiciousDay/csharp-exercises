using System;

int chul = int.Parse(Console.ReadLine());
int young = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

int count = 0;

if (chul >= 60)
{
    Console.WriteLine($"철수: {chul}");
    count++;
}
if (young >= 60)
{
    Console.WriteLine($"영희: {chul}");
    count++;
}
if (min >= 60)
{
    Console.WriteLine($"민수: {chul}");
    count++;
}

if(count == 0)
{
    Console.WriteLine("선발자 없음");
}
else
{
    Console.WriteLine($"선발 인원: {count}");
}
