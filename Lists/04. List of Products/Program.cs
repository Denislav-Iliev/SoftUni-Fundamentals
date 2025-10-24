int count = int.Parse(Console.ReadLine());
List<string> products = new();

for (int i = 0; i < count; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

products.Sort();

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}