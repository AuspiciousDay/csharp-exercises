using CH21Q01;
using System;


Console.Write("정수 값: ");
int value = int.Parse(Console.ReadLine());
Console.Write("눈금 간격: ");
int n = int.Parse(Console.ReadLine());
ValueRule[] valueRules =
{
    new ValueRule(),
    new FloorRule(n),
    new NearestRule(n)
};


foreach (ValueRule valueRule in valueRules)
{
    valueRule.Adjust(value);
}