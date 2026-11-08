using System;
using System.Linq;

class Monster
{
    public string Name { get; }
    public int Power { get; }

    public Monster(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public override string ToString()
    {
        return $"{Name}({Power})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 정수 배열 ===");
        int[] scores = MyArray.ConvertAll("72 95 48 100 60 91 55".Split(' '), int.Parse);

        Console.Write("점수: ");
        MyArray.ForEach(scores, n => Console.Write($"{n}점 "));
        Console.WriteLine();

        Console.WriteLine($"60점 이상 인원: {MyArray.Count(scores, n => n >= 60)}명");

        int index = MyArray.FindIndex(scores, n => n >= 90);
        Console.WriteLine($"첫 90점 이상 위치: {(index == -1 ? "없음" : index.ToString())}");

        Console.Write("합격 여부: ");
        PrintArray(MyArray.ConvertAll(scores, n => n >= 60 ? "합격" : "불합격"));

        MyArray.Sort(scores);
        Console.Write("점수 오름차순: ");
        PrintArray(scores);

        Console.WriteLine();
        Console.WriteLine("=== 문자열 배열 ===");
        string[] words = { "banana", "kiwi", "apple", "fig", "cherry", "grape" };

        Console.Write("단어: ");
        PrintArray(words);

        Console.Write("5글자 이상 단어: ");
        PrintArray(MyArray.Filter(words, n => n.Length >= 5));

        Console.WriteLine($"k로 시작하는 단어 존재 여부: {MyArray.Exists(words, n => n[0] == 'k')}");

        Console.Write("단어 길이: ");
        PrintArray(MyArray.ConvertAll(words, n => n.Length));

        MyArray.Sort(words);
        Console.Write("사전 순 정렬: ");
        PrintArray(words);

        MyArray.Sort(words, (a, b) => a.Length.CompareTo(b.Length));
        Console.Write("길이 순 정렬: ");
        PrintArray(words);

        MyArray.Transform(words, n => n.ToUpper());
        Console.Write("대문자 변환: ");
        PrintArray(words);

        Console.WriteLine();
        Console.WriteLine("=== 몬스터 배열 ===");
        Monster[] monsters =
        {
            new Monster("슬라임", 10),
            new Monster("고블린", 30),
            new Monster("오크", 55),
            new Monster("드래곤", 120),
            new Monster("박쥐", 15),
            new Monster("트롤", 55),
        };

        Console.Write("몬스터: ");
        PrintArray(monsters);

        Console.Write("파워 50 이상: ");
        PrintArray(MyArray.Filter(monsters, n => n.Power >= 50));

        Console.WriteLine($"드래곤 위치: {MyArray.FindIndex(monsters, n => n.Name == "드래곤")}");

        Console.Write("이름 목록: ");
        PrintArray(MyArray.ConvertAll(monsters, n => n.Name));

        MyArray.Sort(monsters, (a, b) => a.Name.CompareTo(b.Name));
        Console.Write("이름 오름차순: ");
        PrintArray(monsters);

        MyArray.Sort(monsters, (a, b) => b.Name.CompareTo(a.Name));
        Console.Write("이름 내림차순: ");
        PrintArray(monsters);

        MyArray.Sort(monsters, (a, b) => a.Power.CompareTo(b.Power));
        Console.Write("파워 오름차순: ");
        PrintArray(monsters);

        MyArray.Sort(monsters, (a, b) => b.Power.CompareTo(a.Power));
        Console.Write("파워 내림차순: ");
        PrintArray(monsters);
    }

    static void PrintArray<T>(T[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}