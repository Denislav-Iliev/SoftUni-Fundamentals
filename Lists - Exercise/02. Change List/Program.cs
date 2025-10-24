List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] input = command.Split();
    if (input[0] == "Delete")
    {
        int elementtoDelete = int.Parse(input[1]);
        list.Remove(elementtoDelete);
    }
    else if (input[0] == "Insert")
    {
        int elementtoInsert = int.Parse(input[1]);
        int indextoInsert = int.Parse(input[2]);
        list.Insert(indextoInsert, elementtoInsert);
    }
}
Console.WriteLine(string.Join(" ", list));