using System;

int fCount = int.Parse(Console.ReadLine());
int add = 0;
bool end = false;
while(!end)
{
    string s = Console.ReadLine();
    switch (s)
    {
        case "add":
            add = 1;
            fCount++;
            Console.WriteLine("추가 완료");
            Console.WriteLine($"수량: {fCount}");
            break;
        case "remove":
            if(fCount > 0)
            {
                add = 2;
                fCount--;
                Console.WriteLine($"수량: {fCount}");
            }
            else if(fCount == 0)
            {
                Console.WriteLine("감소 불가");
                Console.WriteLine($"수량: {fCount}");
            }
            break;
        case "undo":
            if (add == 1)
            {
                fCount--;
                Console.WriteLine($"수량: {fCount}");
            }
            else if(add == 2)
            {
                fCount++;
                Console.WriteLine($"수량: {fCount}");
            }
            else if(add == 0)
            {
                Console.WriteLine("되돌릴 변경 없음");
                Console.WriteLine($"수량: {fCount}");
            }
            add = 0;
            break;
        case "quit":
            end = true;
            break;

    }
}
Console.WriteLine($"최종 수량: {fCount}");