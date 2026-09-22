using System;

Console.Write("측정값: ");
float msrm = float.Parse(Console.ReadLine());

Console.Write("보정값: ");
float crrcVal = float.Parse(Console.ReadLine());

Console.WriteLine($"\n보정 결과: {msrm + crrcVal}");
Console.WriteLine($"표시값: {Math.Clamp(msrm + crrcVal, -50, 50)}");
Console.WriteLine($"표시하지 못한 차이: {Math.Abs(msrm + crrcVal - Math.Clamp(msrm + crrcVal, -50, 50))}");
