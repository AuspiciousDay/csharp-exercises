using CH16Q06;
using System;

Console.Write("상품 수: ");
int count = int.Parse(Console.ReadLine());

Product[] product = new Product[count];

for (int i = 0; i < count; i++)
{
    product[i] = new Product();
    Console.WriteLine($"\n[상품 {i + 1}]");
    Console.Write("코드: ");
    product[i].Code = int.Parse(Console.ReadLine());
    Console.Write("재고: ");
    product[i].Stock = int.Parse(Console.ReadLine());
}

Console.WriteLine("보충 요청수: ");






Product FindProduct(Product[] products, int code)
{
    for (int i = 0; i < products.Length; i++)
    {
        if (products[i].Code == code)
        {
            return products[code];
        }
    }

    return null;
}