using System;

Console.Write("문서 쪽 수: ");
int document = int.Parse(Console.ReadLine());
Console.Write("인쇄 부수: ");
int print = int.Parse(Console.ReadLine());

Console.WriteLine($"기본: {CalculatePrintCost(document)}");
Console.WriteLine($"컬러 1부: {CalculatePrintCost(document, color: true)}");
Console.WriteLine($"컬러 여러 부: {CalculatePrintCost(document, color: true, copies: print)}");


int CalculatePrintCost(int pages, int copies = 1, bool color = false)
{
    int cost = 0;
    if (!color)
    {
        cost += 50 * pages * copies;
    }
    else
    {
        cost += 200 * pages * copies;
    }

    return cost;
}