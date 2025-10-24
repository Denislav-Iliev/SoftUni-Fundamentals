using System.Diagnostics;

string command = "";
decimal totalPrice = 0;

while (true)
{
    command = Console.ReadLine();
    if (command == "special" || command == "regular")
    {
        break;
    }

    decimal price = decimal.Parse(command);
    if (price < 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }
    totalPrice += price;
}

if (totalPrice <= 0)
{
    Console.WriteLine("Invalid order!");
    return;
}

decimal taxes = (totalPrice * (20m / 100m));

Console.WriteLine("Congratulations you've just bought a new computer!");
Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
Console.WriteLine($"Taxes: {taxes:f2}$");
Console.WriteLine("-----------");

decimal totalPriceWithTaxes = totalPrice + taxes;
if (command == "special")
{
    totalPriceWithTaxes -= (totalPriceWithTaxes * 10m) / 100m;
}
Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
