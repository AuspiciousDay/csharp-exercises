using System;

RangeLog rangeLog = new RangeLog();
Console.Write("기록 수: ");
int inputCount = int.Parse(Console.ReadLine());

for (int i = 0; i < inputCount; i++)
{
    Console.Write($"{i + 1}번 기록값: ");
    int record = int.Parse(Console.ReadLine());
    rangeLog.Record(record);
    Console.WriteLine($"{rangeLog.Count}개: {rangeLog.Minimum}~{rangeLog.Maximum}, 폭 {rangeLog.Spread}");
}
Console.WriteLine($"최종: {rangeLog.Count}개: {rangeLog.Minimum}~{rangeLog.Maximum}, 폭 {rangeLog.Spread}");
class RangeLog
{
    public int Count { get; private set; }
    public int Minimum { get; private set; }
    public int Maximum { get; private set; }
    public void Record(int value)
    {
        Count++;
        if (Minimum == 0 && Maximum == 0)
        {
            Minimum = value;
            Maximum = value;
        }
        else if (Maximum < value)
        {
            Maximum = value;
        }
        else if (Minimum > value)
        {
            Minimum = value;
        }
    }

    public int Spread 
    { 
        get { return Maximum - Minimum; } 
    }
}