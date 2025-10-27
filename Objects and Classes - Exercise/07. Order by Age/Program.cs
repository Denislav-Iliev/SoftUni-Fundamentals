class Program
{
    static void Main()
    {
        List<ID> people = new();
        string input = "";

        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();
            bool exists = false;
            foreach (var ID in people)
            {
                if (ID.IDD == arguments[1])
                {
                    ID.Name = arguments[0];
                    ID.Age = int.Parse(arguments[2]);
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                people.Add(new ID(arguments[0], arguments[1], int.Parse(arguments[2])));
            }
        }
        people = people.OrderBy(p => p.Age).ToList();
        foreach (var IDD in people)
        {
            Console.WriteLine(IDD);
        }

    }
}
class ID
{
    public string Name { get; set; }
    public string IDD { get; set;  }
    public int Age { get; set;  }
    public ID(string name, string iDD, int age)
    {
        Name = name;
        IDD = iDD;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Name} with ID: {IDD} is {Age} years old.";
    }
}
