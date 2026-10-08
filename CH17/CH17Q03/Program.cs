using CH17Q03;
using System;

Badge[] badges = { new Badge(), new Badge() };

Console.Write("발급 요청 수: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}번 요청의 번호표 인덱스: ");
    int index = int.Parse(Console.ReadLine());
    Console.WriteLine($"{index}: {badges[index].TryIssue()}, 번호 {badges[index].GetNumber()}, 전체 {badges[index].GetIssuedCount()}");
}

Console.Write($"최종 발급 수: {badges[0].GetIssuedCount()}");
