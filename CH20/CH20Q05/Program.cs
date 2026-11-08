using System;
using Register;
using Dispatch;

Console.Write("초기 재고: ");
int amount = int.Parse(Console.ReadLine());
Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

Attendance attendance = new Attendance();
Warehouse warehouse = new Warehouse(amount);

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"[요청 {i+1}]");
    Console.Write("동작: ");
    string action = Console.ReadLine();
    Console.Write("값(출고 수량 또는 등록 이름): ");
    string dispatchOrRegister = Console.ReadLine();
    if(action == "등록")
    {
        Console.WriteLine($"{attendance.TryRegister(dispatchOrRegister)}: 재고 {warehouse.Counter}, 등록 {attendance.Counter}");
    }
    else if(action == "출고")
    {
        int.TryParse(dispatchOrRegister, out int dispatch);
        Console.WriteLine($"{warehouse.TryDispatch(dispatch)}: 재고 {warehouse.Counter}, 등록 {attendance.Counter}"); 
    }
}
Console.WriteLine($"최종: 재고 {warehouse.Counter}, 등록 {attendance.Counter}");
