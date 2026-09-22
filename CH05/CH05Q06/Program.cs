using System;

Console.Write("정수: ");
sbyte num = sbyte.Parse(Console.ReadLine());

byte transmissionValue = (byte)unchecked(num);
Console.WriteLine($"전송값: {transmissionValue}");

sbyte restoreValue = (sbyte)unchecked(transmissionValue);

Console.WriteLine($"복원값: {restoreValue}");

Console.WriteLine($"원본과 일치: {restoreValue == num}");
