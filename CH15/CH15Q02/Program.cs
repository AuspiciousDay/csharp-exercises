using System;

Console.Write("첫째 값: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("둘째 값: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("셋째 값: ");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine($"시작: {n1}, {n2}, {n3}");
RotateRight(ref n1, ref n2, ref n3);
Console.WriteLine($"1회: {n1}, {n2}, {n3}");
RotateRight(ref n1, ref n2, ref n3);
Console.WriteLine($"2회: {n1}, {n2}, {n3}");


void RotateRight(ref int first, ref int second, ref int third)
{
    int temp = third;
    third = second;
    second = first;
    first = temp;
}