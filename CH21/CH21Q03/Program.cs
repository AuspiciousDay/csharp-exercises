using System;
using CH21Q03;

Console.Write("초기 음량: ");
int volume = int.Parse(Console.ReadLine());
Console.Write("조절 요청 수: ");
int count = int.Parse(Console.ReadLine());

Asset[] asset = new Asset[4];
asset[0] = new SoundAsset(volume);
asset[1] = new PictureAsset();
asset[3] = asset[0];

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"[조절 요청 {i+1}]");
    Console.Write("배열 위치: ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("음량 변화량: ");
    int change = int.Parse(Console.ReadLine());

}