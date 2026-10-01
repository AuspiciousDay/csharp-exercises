using System;

Console.Write("받는 사람 이름: ");
string name = Console.ReadLine();
Console.Write("보관 여부: ");
bool custody = bool.Parse(Console.ReadLine());
Console.Write("메모 본문: ");
string memo = Console.ReadLine();

Console.WriteLine($"받는 사람: \"{name}\"");
Console.WriteLine($"저장: \"C:\\{(custody ? "Archive" : "Inbox")}\\{name}\\note.txt\"");
Console.WriteLine($"본문: {memo}");