using System;

int 전체 = 100;
int 가격 = 12000;
int 예매 = int.Parse(Console.ReadLine());
int 추가 = int.Parse(Console.ReadLine());
int 취소 = int.Parse(Console.ReadLine());

Console.WriteLine($"첫 예매: 예매 {예매}석 / 남은 좌석 {전체 - 예매}석 / 판매 {예매 * 가격}원");
Console.WriteLine($"추가 예매: 예매 {예매 + 추가}석 / 남은 좌석 {전체 - 예매 - 추가}석 / 판매 {(예매 + 추가) * 가격}원");
Console.WriteLine($"취소 후: 예매 {예매 + 추가 - 취소}석 / 남은 좌석 {전체 - (예매 + 추가 - 취소)}석 / 판매 {(예매 + 추가 - 취소) * 가격}원");
