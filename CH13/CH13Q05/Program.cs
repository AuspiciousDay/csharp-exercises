using System;

int N = int.Parse(Console.ReadLine());

string[] s = new string[N];
string[] choice = new string[N];


for(int i = 0; i < N; i++)
{
    Console.Write($"{i + 1}번 경로 : ");
    s[i] = Console.ReadLine();
    s[i] = s[i].Trim();
    int last = s[i].LastIndexOf('\\');

}


