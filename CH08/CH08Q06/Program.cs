using System;
using System.Net.Sockets;
using System.Threading.Tasks;

string w = Console.ReadLine();
int person = int.Parse(Console.ReadLine());
int count = 0;
int n = 0;

switch (w)
{
    case "single":
        count = person / 1;
        n = person % 1;
        if (!(n == 0))
        {
            count++;
            n = 1 - n;
        }
        Console.WriteLine($"묶음 수: {count}");
        Console.WriteLine($"남는 식권: {n}");
        break;
    case "pair":
        n = person % 2;
        count = person / 2;
        if (!(n == 0))
        {
            count++;
            n = 2 - n;
        }
        Console.WriteLine($"묶음 수: {count}");
        Console.WriteLine($"남는 식권: {n}");
        break;
    case "family":
        count = person / 4;
        n = person % 4;
        if (!(n == 0))
        {
            count++;
            n = 4 - n;
        }
        Console.WriteLine($"묶음 수: {count}");
        Console.WriteLine($"남는 식권: {n}");
        break;
    default:
        Console.WriteLine("잘못된 종류");
        break;
}

