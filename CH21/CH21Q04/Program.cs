using CH21Q04;
using System;

Console.Write("측정할 문자열: ");
string text = Console.ReadLine();

WordMeter child = new WordMeter();
TextMeter parent = child;

Console.WriteLine($"부모 측정: {parent.Measure(text)}");
Console.WriteLine($"자식 측정: {child.Measure(text)}");

Console.WriteLine(child.Summary(text));
Console.WriteLine(parent.Summary(text));
