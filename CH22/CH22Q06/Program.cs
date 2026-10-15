using System;
using CH22Q06;

Console.Write("알림 수: ");
int count = int.Parse(Console.ReadLine());
string[] alams = new string[count];
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 알림: ");
    alams[i] = Console.ReadLine();
}
Console.Write("첫 전송기 성공 한도: ");
int quota = int.Parse(Console.ReadLine());
Console.Write("차단 단어: ");
string block = Console.ReadLine();

QuotaTransport quotaTransport = new QuotaTransport(quota);
WordBlockTransport wordBlockTransport = new WordBlockTransport(block);

Outbox outbox = new Outbox(quotaTransport, alams);

int firstSuccess = outbox.Flush();

outbox.ChangeTransport(wordBlockTransport);

int secondSuccess = outbox.Flush();

Console.WriteLine($"1차: 성공 {firstSuccess}, 미전송 {count - firstSuccess}, 시도 {quotaTransport.Attempts}");
Console.WriteLine($"2차: 성공 {secondSuccess}, 미전송 {count - firstSuccess - secondSuccess}, 시도 {wordBlockTransport.Attempts}");
Console.Write($"남은 알림: ");
outbox.PrintRemaining();