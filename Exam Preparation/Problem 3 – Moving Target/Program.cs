using System.Security.Principal;

class Program
{
    static void Main()
    {
        List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] function = command.Split();
            switch (function[0])
            {
                case "Shoot":
                    int index = int.Parse(function[1]);
                    int power = int.Parse(function[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        Shoot(targets, index, power);
                    }                  
                    break;
                case "Add":
                    index = int.Parse(function[1]);
                    int value = int.Parse(function[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        Add(targets, index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                        break;
                case "Strike":
                    index = int.Parse(function[1]);
                    int radius = int.Parse(function[2]);
                    Strike(targets, index, radius);
                    break;

            }
        }
        Console.WriteLine(string.Join("|", targets));

    }
    static void Shoot(List<int> targets, int index, int power)
    {
        targets[index] -= power;
        if (targets[index] <= 0)
        {
            targets.RemoveAt(index);
        }
    }
    static void Add(List<int> targets, int index, int value)
    {
        targets.Insert(index, value);
    }
    static void Strike(List<int> targets, int index, int radius)
    {
        if (index - radius < 0 || index + radius > targets.Count - 1)
        {
            Console.WriteLine("Strike missed!");
            return;
        }
        targets.RemoveRange(index - radius, radius * 2 + 1 );
    }
}