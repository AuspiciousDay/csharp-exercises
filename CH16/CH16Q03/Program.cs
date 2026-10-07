using System;
using CH16Q03;

Memo memo = new Memo();
Memo copyMemo = new Memo();

Console.Write("원본 메모: ");
memo.Text = Console.ReadLine();
Console.Write("원본 수정 번호: ");
memo.Revision = int.Parse(Console.ReadLine());

CopyMemo(copyMemo);

Console.Write("초안의 새 내용: ");
string text = Console.ReadLine();

copyMemo.Edit(text);

Console.WriteLine($"원본: [{memo.Text}] / {memo.Revision}");
Console.WriteLine($"초안: [{copyMemo.Text}] / {copyMemo.Revision}");
Console.WriteLine($"같은 객체: {memo == copyMemo}");

Memo CopyMemo(Memo source)
{
    source.Revision = memo.Revision;
    source.Text = memo.Text;
    return source;
}