using System;

Console.Write("방의 전체 면적: ");
double wholArea = double.Parse(Console.ReadLine());

Console.Write("비워 둘 테두리 폭: ");
double brdrLiWdt = double.Parse(Console.ReadLine());

double len = Math.Sqrt(wholArea);

Console.WriteLine($"\n안쪽 한 변: {len - brdrLiWdt * 2}m");

Console.WriteLine($"사용 면적: {Math.Pow(len - brdrLiWdt * 2, 2)}m^2");
