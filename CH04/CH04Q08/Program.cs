using System;

Console.Write("가로 픽셀 수: ");
int wdthPxl = int.Parse(Console.ReadLine());

Console.Write("세로 픽셀 수: ");
int vrtcPxl = int.Parse(Console.ReadLine());

Console.Write("길이 확대 배율: ");
int mgnf = int.Parse(Console.ReadLine());

Console.WriteLine($"확대 후 픽셀 수: {wdthPxl * vrtcPxl * Math.Pow(mgnf, 2)}");
Console.WriteLine($"추가 메모리: {wdthPxl * vrtcPxl * Math.Pow(mgnf, 2) * 4 - wdthPxl * vrtcPxl * 4}바이트");
