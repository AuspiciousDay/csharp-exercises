using System;

DeliveryKind deliveryKind;
int[] counts = new int[3];
string[] names = Enum.GetNames(typeof(DeliveryKind));
int non = 0;
Console.Write("입력 개수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.Write($"\n{i + 1}번 배송 구분: ");
    string kind = Console.ReadLine();
    if(!Enum.TryParse(kind, out deliveryKind))
    {
        Console.WriteLine("거절");
        non++;
        continue;
    }
    switch (deliveryKind)
    {
        case DeliveryKind.Standard:
            Console.Write($"접수: {deliveryKind}");
            counts[0]++;
            break;
        case DeliveryKind.Express:
            Console.Write($"접수: {deliveryKind}");
            counts[1]++;
            break;
        case DeliveryKind.Pickup:
            Console.Write($"접수: {deliveryKind}");
            counts[2]++;
            break;
        default:
            Console.WriteLine("거절");
            non++;
            break;
    }
}
for(int i = 0;i < names.Length; i++)
{
    Console.WriteLine($"{names[i]} : {counts[i]}");
}
Console.WriteLine($"거절: {non}");

enum DeliveryKind
{
    Standard = 10,
    Express = 20,
    Pickup = 30
}