using System;
using CH17Q04;

Settings[] settings = {new Settings() , new Settings() };

Console.Write("변경 요청 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"\n[변경 요청 {i+1}]");
    Console.Write("칸 번호: ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("값: ");
    int value = int.Parse(Console.ReadLine());
    Console.WriteLine(settings[0].TrySet(index, value));
    settings[0].GetSnapshot();
}

Console.Write("사본에서 바꿀 칸 번호: ");
int number = int.Parse(Console.ReadLine());
Console.Write("사본의 새 값: ");
int newValue = int.Parse(Console.ReadLine());

settings[0].snapshot[number] = newValue;

Console.Write("원본: ");
settings[0].showOrg();
Console.Write("사본: ");
settings[0].showsnap();
Console.Write("다른객체: ");
settings[1].showOrg();