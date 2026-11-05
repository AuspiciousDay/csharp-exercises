using System;

Feature[] devices =
{
    Feature.Print | Feature.Scan, //(Feature)3      0011
    Feature.Print | Feature.Color, //(Feature)5     0101
    Feature.Color | Feature.Network, //(Feature)10  1010
    Feature.Print | Feature.Color | Feature.Scan | Feature.Network, //(Feature)15   1111
    Feature.None //(Feature)0
};

Console.Write("모두 필요한 기능 마스크: ");
Feature required = (Feature)int.Parse(Console.ReadLine());
Console.Write("하나 이상 필요한 기능 마스크: ");
Feature any = (Feature)int.Parse(Console.ReadLine());
Console.Write("금지 기능 마스크: ");
Feature forbidden = (Feature)int.Parse(Console.ReadLine());

string matched = string.Empty;
for (int i = 0; i < devices.Length; i++)
{
    Feature current = devices[i];
    bool allPresent = current.HasFlag(required); // (current & required) == required
    bool anyPresent = any == Feature.None || (current & any) != Feature.None;
    bool nonPresent = (current & forbidden) == Feature.None;

    if (allPresent && anyPresent && nonPresent)
    {
        if (matched.Length > 0)
        {
            matched += ", ";
        }
        matched += i;
    }
}

Console.WriteLine($"선택: [{matched}]");

[Flags]
enum Feature
{
    None = 0,
    Print = 1 << 0,
    Scan = 1 << 1,
    Color = 1 << 2,
    Network = 1 << 3
}