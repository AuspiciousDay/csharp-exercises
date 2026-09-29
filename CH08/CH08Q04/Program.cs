using System;

int copy = int.Parse(Console.ReadLine());
int pay;

if(copy < 11)
{
    pay = copy * 100;
}
else if(copy < 51)
{
    pay = (copy - 10) * 80 + 1000;
}
else
{
    pay = (copy - 50) * 60 + 4200;
}

Console.WriteLine($"복사 요금: {pay}원");