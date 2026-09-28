using System;

int beginningInventory = int.Parse(Console.ReadLine());

int cheolCount = int.Parse(Console.ReadLine());
int cheolMoney = int.Parse(Console.ReadLine());

int yongCount = int.Parse(Console.ReadLine());
int yongMoney = int.Parse(Console.ReadLine());

bool cheolRental = cheolCount > 0 && cheolMoney >= cheolCount * 500;
int cheolPay = cheolRental ? cheolCount * 500 : 0;

beginningInventory = cheolRental ? beginningInventory - cheolCount : beginningInventory;

bool yongRental = yongCount > 0 && beginningInventory > yongCount && yongMoney >= yongCount * 500;
int yongPay = yongRental ? yongCount * 500 : 0 ;

beginningInventory = yongRental ? beginningInventory - yongCount : beginningInventory;


Console.WriteLine($"철수 대여: {cheolRental} / 보유 금액: {cheolMoney - cheolPay}");
Console.WriteLine($"영희 대여: {yongRental} / 보유 금액: {yongMoney - yongPay}");
Console.WriteLine($"남은 재고: {beginningInventory}");
Console.WriteLine($"받은 보증금: {cheolPay + yongPay}");