using System;

Console.Write("바이트 수: ");
long byteCount = long.Parse(Console.ReadLine());

Console.Write("바이트 수: ");
long frameCount = long.Parse(Console.ReadLine());

Console.WriteLine($"\n필요한 저장량: {byteCount * frameCount}바이트");