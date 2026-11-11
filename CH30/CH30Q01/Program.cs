using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

Console.Write("정수 개수: ");
int n = int.Parse(Console.ReadLine());

int[] values = new int[n];

for(int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}번째 정수: ");
    values[i] = int.Parse(Console.ReadLine());
}

SomeClass A = new SomeClass(values);
SomeClass B = A;

Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0;i < count; i++)
{
    Console.Write($"{i+1}번 요청 열거자: ");
    string s = Console.ReadLine();
    if(s == "A")
    { 
        foreach (var v in A)
        {
            Console.WriteLine(v);
        }
        
    }
    else
    {
        foreach (var v in B)
        {
            Console.WriteLine(v);
        }
    }
    
}

Console.Write("전체: ");
foreach(int i in values)
{
    Console.WriteLine(A.GetEnumerator());
}

class SomeClass
{
    private int[] values;

    public SomeClass(int[] values)
    {
        this.values = values;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach(var i in values)
        {
            if (values.Length % 2 == 0)
            {
                yield return i;
            }
        }
        foreach (int i in values)
        {
            if (values.Length % 2 == 1)
            {
                yield return i;
            }
        }
    }
}