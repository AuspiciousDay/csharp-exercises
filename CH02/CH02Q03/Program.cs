using System;

class Program
{
    static void Main()
    {
        int note = 1200;
        int pen = 800;
        int pay = 10000;

        Console.WriteLine("=== 문구점 영수증 ===");
        Console.WriteLine($"\n공책: {note}원 x 3권 = {note * 3}");
        Console.WriteLine($"펜: {pen}원 x 2개 = {pen * 2}");
        Console.WriteLine($"\n합계: {note * 3 + pen * 2}원");
        Console.WriteLine($"결제: {pay}원");
        Console.WriteLine($"거스름돈: {pay - (note * 3 + pen * 2)}원");

    }
}