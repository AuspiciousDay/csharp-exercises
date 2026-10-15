using CH22Q03;
using System;

Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());
object[] data =
{
    new NameTag(),
    new Storage(),
    new LockableNameTag(),
    null
};

NameTag nameTag = (NameTag)data[0];
Storage storage = (Storage)data[1];
LockableNameTag lockableNameTag = (LockableNameTag)data[2];

for (int i = 0; i < count; i++)
{
    bool result = false;

    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string action = Console.ReadLine();

    Console.Write("대상 번호: ");
    int number = int.Parse(Console.ReadLine());

    if (action == "편집")
    {
        Console.Write("새 이름: ");
        string name = Console.ReadLine();

        if (data[number] is IEditable editable)
        {
            result = editable.Replace(name);
        }
    }
    else if (action == "잠금")
    {
        if (data[number] is ILockable lockable)
        {
            result = lockable.Lock();
        }
    }

    Console.WriteLine($"{result}: {nameTag.Name} / {storage.IsLocked} / {lockableNameTag.Name},{lockableNameTag.IsLocked}");
}
Console.WriteLine($"최종: {nameTag.Name} / {storage.IsLocked} / {lockableNameTag.Name},{lockableNameTag.IsLocked}");