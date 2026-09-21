using System;

int 단가 = int.Parse(Console.ReadLine());
int 최초수량 = int.Parse(Console.ReadLine());
int 변경수량 = int.Parse(Console.ReadLine());

Console.WriteLine($"변경 전: {최초수량}개 / {최초수량 * 단가}");
Console.WriteLine($"변경 후: {변경수량}개 / {변경수량 * 단가}");
Console.WriteLine($"금액 차이: {변경수량 * 단가 - 최초수량 * 단가}");