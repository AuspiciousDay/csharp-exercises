using System;

bool validity = false;
int i = 1;
do
{
    string n = Console.ReadLine();
    bool can = int.TryParse(n, out int id);
    if (!can)
    {
        Console.WriteLine("정수 필요");
        i++;
        continue;
    }
    else if (id < 1 || id > 10)
    {
        Console.WriteLine("범위 오류");
        i++;
        continue;

    }
    else
    {
        Console.WriteLine($"확정 번호: {id}");
        Console.WriteLine($"시도 수: {i}");
        validity = true;
        break;
    }

} while (!validity || i <= 3);

