int commandQuantity = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();
string name;

for (int i = 0; i < commandQuantity; i++)
{
    string input = Console.ReadLine();
    string[] parts = input.Split();
    if (parts[2] == "going!")
    {
        name = parts[0];
        if (guests.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guests.Add(name);
        }
    }
    else if (parts[2] == "not")
    {
        name = parts[0];
        if (guests.Contains(name))
        {
            guests.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}
Console.WriteLine(string.Join("\n", guests));