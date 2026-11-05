using System;

int[] numbers = { 0, 5, -2, 8 };
string[] letters = { "B", "A", "D", "C" };

Console.Write("정수 하한: ");
int lower = int.Parse(Console.ReadLine());
Console.Write("정수 상한: ");
int upper = int.Parse(Console.ReadLine());
Console.Write("문자열 하한: ");
string first = Console.ReadLine();
Console.Write("문자열 상한: ");
string last = Console.ReadLine();

bool numberFound = TryFindFirst(numbers, lower, upper, out int number);
bool letterFound = TryFindFirst(letters, first, last, out string letter);

Console.WriteLine($"정수 {numberFound}: [{number}]");
Console.WriteLine($"문자 {letterFound}: [{letter}]");

static bool TryFindFirst<T>(T[] values, T lower, T upper, out T result) where T : IComparable<T>
{
    result = default(T);
    if(lower.CompareTo(upper) > 0)
    {
        return false;
    }
    foreach (T value in values)
    {
        if(value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0)
        {
            result = value;
            return true;
        }
    }

    return false;
}