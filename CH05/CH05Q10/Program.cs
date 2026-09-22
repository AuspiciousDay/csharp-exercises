using System;

Console.Write("첫째 이동량: ");
decimal move1 = decimal.Parse(Console.ReadLine());

Console.Write("둘째 이동량: ");
decimal move2 = decimal.Parse(Console.ReadLine());

decimal carryForward = move1 % 1;

Console.WriteLine($"첫 전송: {(int)(move1 / 1)}");
Console.WriteLine($"두 번째 전송: {(int)(move2 + carryForward) / 1}");
Console.WriteLine($"최종 잔량: {(move2 + carryForward) % 1}");
Console.WriteLine($"총 전송량: {(int)(move1 + move2) / 1}");
