int yield = int.Parse(Console.ReadLine());
int spice = 0;
int days = 0;

while (yield >= 100)
{
    days++;
    spice += yield;
    spice -= 26;
    yield -= 10;
}
spice = Math.Max(0, spice - 26);

Console.WriteLine(days);
Console.WriteLine(spice);