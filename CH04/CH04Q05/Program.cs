using System;
using System.Runtime.InteropServices;

Console.Write("주차한 분 수: ");
float minute = float.Parse(Console.ReadLine());

const int charge = 1500;

Console.WriteLine($"\n완전히 지난 시간: {Math.Floor(minute / 60)}");

Console.WriteLine($"과금 시간: {Math.Ceiling(minute / 60)}");

Console.WriteLine($"요금: {Math.Ceiling(minute / 60) * charge}");