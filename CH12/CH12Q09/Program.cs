using System;

Console.Write("상품 수: ");
int N = int.Parse(Console.ReadLine());

string[] name = new string [N];
int[] unitPrice = new int[N];
int[] order = new int[N];
int[] inventory = new int[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"[상품 {i+1}]");
    Console.Write("식별자: ");
    name[i] = Console.ReadLine();
    Console.Write("단가: ");
    unitPrice[i] = int.Parse(Console.ReadLine());
    Console.Write("주문 수량: ");
    order[i] = int.Parse(Console.ReadLine());
    Console.Write("재고: ");
    inventory[i] = int.Parse(Console.ReadLine());
}

Console.Write("할인율(%): ");
int discount  = int.Parse(Console.ReadLine());

