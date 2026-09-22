using System;

Console.Write("현재 밝기: ");

int luminosity = int.Parse(Console.ReadLine());

const int MinLuminosity = 0;
const int MaxLuminosity = 255;

Console.WriteLine($"\n낮출 수 있는 양: {luminosity - MinLuminosity}");
Console.WriteLine($"높일 수 있는 양: {MaxLuminosity - luminosity}");
