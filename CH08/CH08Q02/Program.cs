using System;

bool isOn = bool.Parse(Console.ReadLine());
int temperature = int.Parse(Console.ReadLine());

if(temperature <= 18)
{
    isOn = true;
}
else if(temperature >= 22)
{
    isOn = false;
}

Console.WriteLine($"난방 켜짐: {isOn}");