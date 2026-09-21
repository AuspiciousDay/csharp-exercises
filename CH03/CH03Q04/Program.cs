using System;

int 첫영상분 = int.Parse(Console.ReadLine());
int 첫영상초 = int.Parse(Console.ReadLine());
int 두번째영상분 = int.Parse(Console.ReadLine());
int 두번째영상초 = int.Parse(Console.ReadLine());

Console.WriteLine($"첫 영상: {첫영상분 * 60 + 첫영상초}초");
Console.WriteLine($"두 번째 영상: {두번째영상분 * 60 + 두번째영상초}초");
Console.WriteLine($"합계: {첫영상분 * 60 + 첫영상초 + 두번째영상분 * 60 + 두번째영상초}초");

