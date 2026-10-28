using System;

Console.Write("정수 개수: ");
int count = int.Parse(Console.ReadLine());

int[] ints = new int[count];
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 정수: ");
    ints[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"폭: {Interval(ints)}");
Console.WriteLine($"변화: {Count(ints)}");

Measure Interval(int[] ints)
{
    return ints =>
    {
        int max = ints[0];
        int min = ints[0];
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] > max)
            {
                max = ints[i];
            }
            else if (ints[i] < min)
            {
                min = ints[i];
            }
        }
        return max - min;
    };    
}
Measure Count(int[] ints)
{
    int count = 0;
    return ints =>
    {
        for (int i = 0; i < ints.Length - 1; i++)
        {
            if (ints[i] != ints[i + 1])
            {
                count++;
            }
        }
        return count;
    };
    
}


delegate int Measure(int[] ints);