int count = int.Parse(Console.ReadLine());
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
decimal bestValue = 0;

for (int i = 0; i < count; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    decimal value = (decimal)Math.Pow((double)snow / time, quality);
    if (bestValue < value)
    {
        bestValue = value;
        bestSnow = snow;
        bestTime = time;
        bestQuality = quality;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");