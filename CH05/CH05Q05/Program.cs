using System;

Console.Write("1번 밝기 값: ");
byte luminosity1 = byte.Parse(Console.ReadLine());

Console.Write("2번 밝기 값: ");
byte luminosity2 = byte.Parse(Console.ReadLine());

int sum1 = luminosity1 + luminosity2;
byte sum2 = (byte)unchecked(luminosity1 + luminosity2);

Console.WriteLine($"정확한 합계: {sum1}");
Console.WriteLine($"byte 저장값: {sum2}");
Console.WriteLine($"값 보존: {sum1 == sum2}");