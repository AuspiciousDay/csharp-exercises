using System;
using CH17Q01;

RangeSetting rangeSetting = new RangeSetting();

Console.Write("설정 요청 수: ");
int setting = int.Parse(Console.ReadLine());

for(int i = 0; i < setting; i++)
{
    Console.WriteLine($"\n[설정 요청 {i+1}]");
    Console.Write("하한: ");
    int lower = int.Parse(Console.ReadLine());
    Console.Write("상한: ");
    int upper = int.Parse(Console.ReadLine());
    rangeSetting.ShowRange(rangeSetting.TrySet(lower,upper));
    
}

rangeSetting.final();