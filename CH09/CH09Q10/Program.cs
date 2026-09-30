using System;

int stock = int.Parse(Console.ReadLine());
int target = int.Parse(Console.ReadLine());
int attempts = 0;
int accepted = 0;
int allocated = 0;

while (accepted < stock && stock > 0)
{
    string input = Console.ReadLine();
    attempts++;
    if(!int.TryParse(input, out int quantity))
    {
        Console.WriteLine("정수 필요");
    }
    else if(quantity < 1 || quantity > 5)
    {
        Console.WriteLine("수량인 1~5");
    }
    else if(quantity > stock)
    {
        Console.WriteLine("재고 부족");
    }
    else
    {
        stock -= quantity;
        allocated += quantity;
        accepted++;
        Console.WriteLine($"접수 {accepted}: {quantity}개");
    }
}

Console.WriteLine($"시도: {attempts}");
Console.WriteLine($"접수: {accepted}");
Console.WriteLine($"배정: {allocated}");
Console.WriteLine($"재고: {stock}");
string reason = accepted >= target ? "목표달성" : "재고소진";
Console.WriteLine($"종료: {reason}");

