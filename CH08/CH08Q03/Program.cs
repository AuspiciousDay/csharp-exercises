using System;

int capacity = 64;

string input = Console.ReadLine();

if(!int.TryParse(input, out int requested))
{
    Console.WriteLine("정수 변환 실패");
}
else if(requested < 16 ||  requested > 256)
{
    Console.WriteLine("허용 범위 아님");
}
else
{
    capacity = requested;
    Console.WriteLine("설정 완료");
}

Console.WriteLine($"최종 용량: {capacity}");