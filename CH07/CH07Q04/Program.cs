using System;

string pre = Console.ReadLine();
string now = Console.ReadLine();
bool shutOut = bool.Parse(Console.ReadLine());

Console.WriteLine($"내용 변경: {pre != now}");
Console.WriteLine($"알림 발생: {!shutOut}");