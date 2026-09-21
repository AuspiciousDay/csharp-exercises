using System;

string fr = Console.ReadLine();
string sc = Console.ReadLine();
string th = Console.ReadLine();

Console.WriteLine($"이동 전: {fr} / {sc} / {th}");

string ch = fr;
fr = th;
th = sc;
sc = ch;

Console.WriteLine($"이동 후: {fr} / {sc} / {th}");
