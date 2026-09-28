using System;

int frStart = int.Parse(Console.ReadLine());
int frEnd = int.Parse(Console.ReadLine());
int scStart = int.Parse(Console.ReadLine());
int scEnd = int.Parse(Console.ReadLine());

Console.WriteLine($"예약 겹침: {frEnd > scStart}");
Console.WriteLine($"겹친 시간: {(frEnd > scStart ? frEnd - scStart : 0)}");