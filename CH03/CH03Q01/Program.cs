using System;

int pay = 3000;

string name = Console.ReadLine();
string space = Console.ReadLine();
int box = int.Parse(Console.ReadLine());
Console.WriteLine($"받는 사람: {name}");
Console.WriteLine($"주소: {space}");
Console.WriteLine($"상자: {box}개");
Console.WriteLine($"배송비: {pay * box}원");