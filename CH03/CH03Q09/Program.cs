using System;

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int AB = int.Parse(Console.ReadLine());
int BA = int.Parse(Console.ReadLine());

Console.WriteLine($"시작: A {A}개 / B {B}개");
Console.WriteLine($"A->B 후: A {A - AB}개 / B {B + AB}개");
Console.WriteLine($"B->A 후: A {A - AB + BA}개 / B {B + AB - BA}개");
Console.WriteLine($"총 재고: {A + B}개");

