using System;

Profile profile = new Profile();
Console.Write("이름 대입수: ");
int inputCount = int.Parse(Console.ReadLine());

for (int i = 0; i < inputCount; i++)
{
    Console.Write($"{i + 1}번째 이름: ");
    profile.Name = Console.ReadLine();
    Console.WriteLine($"[{profile.Name}], 변경 {profile.Changes}");
}
Console.Write("덧붙일 문자열: ");
profile.Name += Console.ReadLine();
Console.WriteLine($"최종: [{profile.Name}], 변경{profile.Changes}");

class Profile
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (name != value.Trim() && value.Trim() != "")
            {
                name = value;
                Changes++;
            }
        }
    }
    public int Changes { get; private set; }
}