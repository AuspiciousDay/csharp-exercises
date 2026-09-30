using System;

int N = int.Parse(Console.ReadLine());

int[] n = new int[N];
for(int i = 0; i < N; i++)
{
    int price = int.Parse(Console.ReadLine());
    n[i] = price;
}

int discount = int.Parse(Console.ReadLine());
int chNumber = int.Parse(Console.ReadLine());
int afPrice = int.Parse(Console.ReadLine());

int[] preview = new int [N];

for(int i = 0;i < N; i++)
{
    if (n[i] < discount)
    {
        preview[i] = 0;
    }
    else
    {
        preview[i] = n[i] - discount;
    }
    
}

n[chNumber] = afPrice;

Console.Write("원본: ");
for (int i = 0; i < N; i++)
{
    Console.Write($"{n[i]} ");
}

Console.Write("\n미리보기: ");
for (int i = 0; i < N; i++)
{
    Console.Write($"{preview[i]} ");
}
