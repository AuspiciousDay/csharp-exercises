using System;

string s = Console.ReadLine();
int box = 300;
int gift = 500 + box;
int basic = 100;


switch (s)
{
    case "box":
        Console.WriteLine($"포장비: {box}");
        break;
    case "gift":
        Console.WriteLine($"포장비: {gift}");
        break;
    case "old":
        Console.WriteLine("옵션 변경");
        goto default;
    default:
        Console.WriteLine($"포장비: {basic}");
        break;
}
