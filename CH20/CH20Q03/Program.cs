using System;
using CH20Q03;

Console.Write("페이지 수: ");
int pages = int.Parse(Console.ReadLine());
Console.Write("지정 부수: ");
int count = int.Parse(Console.ReadLine());

Booklet basicBooklet = new Booklet(pages);
Booklet booklet = new Booklet(pages,count);


Console.WriteLine($"기본: {basicBooklet.Pages}쪽, {basicBooklet.Copies}부, {basicBooklet.Sheets}장");
Console.WriteLine($"지정: {booklet.Pages}쪽, {booklet.Copies}부, {booklet.Sheets}장");