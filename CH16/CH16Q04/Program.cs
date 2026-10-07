using System;
using CH16Q04;

Console.Write("객체 수: ");
int objectCount = int.Parse(Console.ReadLine());

Token[] obIndex = new Token[objectCount];


for(int i = 0; i < objectCount; i++)
{
    obIndex[i] = new Token();

    Console.WriteLine($"[객체 인텍스 {i}]");
    Console.Write("이름: ");
    obIndex[i].Name = Console.ReadLine();
    Console.Write("값: ");
    obIndex[i].Value = int.Parse(Console.ReadLine());
}

Console.Write("참조 수: ");
int count = int.Parse(Console.ReadLine());
Token[] counts = new Token[count];

for(int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번째 참조의 객체 인덱스: ");
    counts[i] = obIndex[int.Parse(Console.ReadLine())];
}
int sum = 0;
objectCount = 0;
for(int i = 0;i < count; i++)
{
    for(int j = count - 1; j >= 0; j--)
    {
        if (counts[i] == counts[j])
        {
            break;
        }
        else
        {
            Console.WriteLine($"{counts[i].Name}: {counts[i].Value}");
            sum += counts[i].Value;
            objectCount++;
        }
    }
}

Console.WriteLine($"객체 수: {objectCount}, 합계: {sum}");