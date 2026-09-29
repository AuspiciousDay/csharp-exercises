using System;

string set = Console.ReadLine();
int money = int.Parse(Console.ReadLine());
string commend = Console.ReadLine();

int setMoney = 3000;

switch (commend)
{
    case "pay":
        if(set == "접수")
        {
            if(money > setMoney)
            {
                money -= setMoney;
                set = "결제";
                Console.WriteLine("결제 완료");
            }
            else
            {
                Console.WriteLine("잔액 부족");
            }
        }
        else
        {
            Console.WriteLine("결제할 수 없는 상태");
        }
        break;
    case "ship":
        if(set == "결제")
        {
            Console.WriteLine("발송 완료");
        }
        else
        {
            Console.WriteLine("발송할 수 없는 상태");
        }
        break;
    case "cancel":
        if(set == "접수")
        {
            set = "취소";
            Console.WriteLine("접수 취소");
        }
        else if(set == "결제")
        {
            money += setMoney;
            set = "취소";
            Console.WriteLine("결제 취소 및 환불");
        }
        else if (set == "발송")
        {
            Console.WriteLine("발송 후 취소 불가");
        }
        else
        {
            Console.WriteLine("이미 취소됨");
        }
        break;
    default:
        Console.WriteLine("알수 없는 명령");
        break;
}

Console.WriteLine($"상태: {set}");
Console.WriteLine($"잔액: {money}");