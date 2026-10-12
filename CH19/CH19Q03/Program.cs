using System;
using System.Data;

GridLayout gridLayout = new GridLayout();
Console.Write("초기 항목 수: ");
gridLayout.ItemCount = int.Parse(Console.ReadLine());
int row;
int column = gridLayout.Columns;
if(gridLayout.ItemCount % column == 0)
{
    row = gridLayout.ItemCount / column;
}
else
{
    row = gridLayout.ItemCount / column + 1;
}

Console.Write("바꿀 열 수: ");
gridLayout.Columns = int.Parse(Console.ReadLine());

Console.Write("바꿀 항목 수: ");
gridLayout.ItemCount = int.Parse(Console.ReadLine());

Console.WriteLine($"초기: {row}행, 빈칸 {gridLayout.EmptySlots}");
Console.WriteLine($"열 변경: {gridLayout.Rows}행, 빈칸 {gridLayout.EmptySlots}");
Console.WriteLine($"개수 변경: {gridLayout.Rows}행, 빈칸 {gridLayout.EmptySlots}");
Console.WriteLine($"저장한 행 수: {row}");


class GridLayout
{
    private int row;
    public int ItemCount { get; set; }
    public int Columns { get; set; } = 4;
    public int Rows 
    { 
        get {  return row; }
        set
        {
            if (ItemCount % Columns == 0)
            {
                row = ItemCount / Columns;
            }
            else
            {
                row = ItemCount / Columns + 1;
            }
        }
    }
    public int EmptySlots 
    { 
        get { return Rows * Columns - ItemCount; } 
    }
}