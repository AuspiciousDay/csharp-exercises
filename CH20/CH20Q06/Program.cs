using System;
using CH20Q06;

Console.Write("첫 보고서 제목: ");
string firstTitle = Console.ReadLine();
Console.Write("두 번째 보고서 제목: ");
string secondTitle = Console.ReadLine();

Console.Write("최초 표시 폭: ");
int firstWitdth = int.Parse(Console.ReadLine());
Console.Write("변경할 표시 폭: ");
int nextWitdth = int.Parse(Console.ReadLine());

CaptionFormatter shared = new CaptionFormatter("#",firstWitdth);
Report first = new Report(firstTitle,shared);
Report second = new Report(secondTitle, shared);

Console.WriteLine($"초기: {first.Render()} / {second.Render()}");
shared.Width = nextWitdth;
Console.WriteLine($"공유 변경: {first.Render()} / {second.Render()}");

first.Formmater = new CaptionFormatter("!", 1);
Console.WriteLine($"서식 교체: {first.Render()} / {second.Render()}");

first.Formmater = null;
Console.WriteLine($"서식 없음: {first.Render()}");
