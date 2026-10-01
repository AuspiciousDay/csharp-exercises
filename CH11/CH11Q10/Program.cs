using System;
using System.Reflection.Metadata;

Console.Write("행 수: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("열 수: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("예약 요청 수: ");
int requests = int.Parse(Console.ReadLine());

bool[,] seats = new bool[rows, columns];

for(int requset  = 0; requset < requests; requset++)
{
    Console.WriteLine();
    Console.WriteLine($"[예약 요청 {requset + 1}]");
    Console.Write("행 번호: ");
    int rowNumber = int.Parse(Console.ReadLine());
    Console.Write("시작 열 번호: ");
    int firstColumn = int.Parse(Console.ReadLine());
    Console.Write("인원: ");
    int people = int.Parse(Console.ReadLine());

    if (rowNumber < 1 || rowNumber > seats.GetLength(0) || 
        firstColumn < 1 || firstColumn > seats.GetLength(1) ||
        people < 1 || firstColumn + people - 1 > seats.GetLength(1))
    {
        Console.WriteLine("범위 오류");
        continue;
    }

    int row = rowNumber - 1;
    int start = firstColumn - 1;
    bool available = true;
    for(int column = start; column < start + people; column++)
    {
        if (seats[row, column])
        {
            available = false;
            break;
        }
    }

    if (!available)
    {
        Console.WriteLine("예약 불가");
        continue;
    }

    for (int column = start; column < start + people; column++)
    {
        seats[row, column] = true;
    }
    Console.WriteLine("예약 완료");
}

int reserved = 0;
for(int row = 0;row <seats.GetLength(0); row++)
{
    for(int column = 0; column < seats.GetLength(1); column++)
    {
        Console.WriteLine(seats[row,column] ? "X":"O");
        if (seats[row, column])
        {
            reserved++;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"예약 좌석: {reserved}");