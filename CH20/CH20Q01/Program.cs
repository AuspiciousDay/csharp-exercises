using System;
using System.Security.Cryptography.X509Certificates;
using CH20Q01;


Console.Write("태그: ");
string tag = Console.ReadLine();
Console.Write("초기 본문: ");
string text = Console.ReadLine();
Console.Write("새 본문: ");
string newText = Console.ReadLine();
Console.Write("덧붙일 메모: ");
string addMemo = Console.ReadLine();

TaggedRecord taggedRecord = new TaggedRecord()
{
    Tag = tag,
    Text = text
};

Console.WriteLine(taggedRecord.Formatted);
taggedRecord.Text = newText;
Console.WriteLine(taggedRecord.Formatted);
AppendNote appendNote = new AppendNote(addMemo);
Console.WriteLine(taggedRecord.Formatted);