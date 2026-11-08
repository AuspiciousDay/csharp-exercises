using CH23Q01;
using System;

Console.Write("전체 수량: ");
int total = int.Parse(Console.ReadLine());

Console.Write("현재 예약량: ");
int initialReserved = int.Parse(Console.ReadLine());

StockState stock = new StockState(total, initialReserved);

Console.Write("미리 볼 예약량: ");
int previewAmount = int.Parse(Console.ReadLine());

StockState preview = Preview(stock, previewAmount, out bool success);
Console.WriteLine($"미리보기 {success}: {preview}");
Console.WriteLine($"원본: {stock}");

Console.Write("실제 예약량: ");
int actualAmount = int.Parse(Console.ReadLine());
bool reserved = TryReserve(ref stock, actualAmount);
Console.WriteLine($"확정 {reserved}: {stock}");

static StockState Preview(StockState state, int amount, out bool success)
{
    success = TryReserve(ref state, amount);
    return state;
}
static bool TryReserve(ref StockState state, int amount)
{
    if (amount <= 0 || amount > state.Available)
    {
        return false;
    }
    state.Reserved += amount;
    return true;
}
