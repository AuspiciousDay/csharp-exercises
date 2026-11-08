using CH16Q01;
using System;

Course am = new Course();
am.Name = "오전";
Course pm = new Course();
pm.Name = "오후";

Console.Write("오전 강좌 정원: ");
am.Capacity = int.Parse(Console.ReadLine());
Console.Write("오전 현재 신청 인원: ");
am.Enrolled = int.Parse(Console.ReadLine());
Console.Write("오후 강좌 정원: ");
pm.Capacity = int.Parse(Console.ReadLine());
Console.Write("오후 현재 신청 인원: ");
pm.Enrolled = int.Parse(Console.ReadLine());
Console.Write("오전 추가 신청 인원: ");
int dayAddEnrolled = int.Parse(Console.ReadLine());
Console.Write("오후 추가 신청 인원: ");
int nightAddEnrolled = int.Parse(Console.ReadLine());

Console.WriteLine($"{am.Name}: {am.TryEnroll(dayAddEnrolled)}, 잔여 {am.GetRemaining()}");
Console.WriteLine($"{pm.Name}: {pm.TryEnroll(nightAddEnrolled)}, 잔여 {pm.GetRemaining()}");
Console.WriteLine($"잔여 합계: {am.GetRemaining() + pm.GetRemaining()}");
