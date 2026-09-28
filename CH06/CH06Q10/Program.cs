using System;

string maxPerson = Console.ReadLine();
string speed = Console.ReadLine();
string use = Console.ReadLine();

bool isSuccess1 = int.TryParse(maxPerson, out int result1);
bool isSuccess2 = double.TryParse(speed, out double result2);
bool isSuccess3 = bool.TryParse(use, out bool result3);

int success = Convert.ToInt32(isSuccess1) + Convert.ToInt32(isSuccess2) + Convert.ToInt32(isSuccess3);


Console.WriteLine($"인원 [{maxPerson}]: {isSuccess1} / {result1} / {result1.GetType()}");
Console.WriteLine($"속도 [{speed}]: {isSuccess2} / {result2} / {result2.GetType()}");
Console.WriteLine($"알림 [{use}]: {isSuccess3} / {result3} / {result3.GetType()}");
Console.WriteLine($"변환 성공: {success} / 모두 성공: {success == 3}");