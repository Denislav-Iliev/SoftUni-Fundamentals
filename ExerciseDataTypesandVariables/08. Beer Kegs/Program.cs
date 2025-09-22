int beerKegs = int.Parse(Console.ReadLine());
double biggestVolume = double.MinValue;
string biggestmodel = string.Empty;

for (int i = 1; i <= beerKegs; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volume = Math.PI * (radius * radius) * height;
    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestmodel = model;
    }
}
Console.WriteLine(biggestmodel);