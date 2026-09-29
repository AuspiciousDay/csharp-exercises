using System;

int n = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
string result = "처리완료";

switch (command)
{
    case "next":
    case "n":
        n = Math.Min(n + 1, 9);
        break;
    case "previous":
    case "p":
        n = Math.Max(n - 1, 0);
        break;
    case "first":
        n = 0;
        break;
    case "last":
        n = 9;
        break;
    default:
        result = "알 수 없음";
        break;
}
Console.WriteLine(result);
Console.WriteLine($"선택 번호: {n}");