using System.Globalization;

List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string line = Console.ReadLine();

    if (line == "end")
    {
        break;
    }

    string[] tokens = line.Split();
    switch (tokens[0])
    {
        case "Add":
            int numberToAdd = int.Parse(tokens[1]);
            integers.Add(numberToAdd);
            break;
        case "Remove":
            int numberToRemove = int.Parse(tokens[1]);
            integers.Remove(numberToRemove);
            break;
        case "RemoveAt":
            int indexToRemoveAt = int.Parse(tokens[1]);
            integers.RemoveAt(indexToRemoveAt);
            break;
        case "Insert":
            int numberToInsert = int.Parse(tokens[1]);
            int indexToInsert = int.Parse(tokens[2]);
            integers.Insert(indexToInsert, numberToInsert);
            break;
    }
}
Console.WriteLine(string.Join(" ", integers));