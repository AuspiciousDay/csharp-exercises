using System;

Console.Write("측정값 수: ");
int measurement = int.Parse(Console.ReadLine());
int[] n = new int[measurement];

for (int i = 0; i < measurement; i++)
{
    Console.Write($"{i + 1}번 측정값: ");
    n[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"측정값: [{string.Join(", ", n)}]");

Console.WriteLine($"차이: [{string.Join(", ", GetChanges(n))}]");

int[] GetChanges(int[] readings)
{
    int[] N = new int[readings.Length - 1];
    if (readings.Length < 2)
    {
        return readings;
    }
    for (int i = 0; i < readings.Length - 2; i++)
    {
        N[i] = readings[i + 1] - readings[i];
    }
    return N;
}