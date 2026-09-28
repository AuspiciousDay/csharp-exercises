using System;

bool isCoupon = bool.Parse(Console.ReadLine());
bool isPoint = bool.Parse(Console.ReadLine());
int point = int.Parse(Console.ReadLine());

bool isApplication = (isCoupon ? (isPoint ? false : true) : (isPoint ? true : false));

Console.WriteLine($"할인 적용: {isApplication}");
Console.WriteLine($"할인액: {(isApplication ? 1000 :0)}");
Console.WriteLine($"남은 포인트: {(isPoint ? (point > 100 ? point - 100 : point) : point)}");