using CH26Q02;
using System;

Console.Write("최초 보정값: ");
int firstOffset = int.Parse(Console.ReadLine());
Console.Write("새 객체 보정값: ");
int newOffset = int.Parse(Console.ReadLine());
Console.Write("원래 객체의 새 보정값: ");
int changedOffset = int.Parse(Console.ReadLine());
Console.Write("측정값: ");
int value = int.Parse(Console.ReadLine());

Calibrator orginal = new Calibrator(firstOffset);
Calibrator current = orginal;

Func<int, int> saved = current.Adjust;
Console.WriteLine($"처음: {saved(value)}");
current = new Calibrator(newOffset);
orginal.Offset = changedOffset;
Console.WriteLine($"보관: {saved(value)}");
Console.WriteLine($"현재: {current.Adjust(value)}");
