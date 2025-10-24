using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> usernames = Console.ReadLine().Split(", ").ToList();
string command = "";
List<string> blacklisted = new List<string>();
List<string> lost = new List<string>();

while ((command = Console.ReadLine()) != "Report")
{
    string[] input = command.Split();
    switch (input[0])
    {
        case "Blacklist":
            string name = input[1];
            int index = usernames.IndexOf(name);
            if (usernames.Contains(name))
            {
                Console.WriteLine($"{name} was blacklisted.");
                blacklisted.Add(name);
                usernames[index] = "Blacklisted";
            }
            else
            {
                Console.WriteLine($"{name} was not found.");
            }
                break;
        case "Error":
            index = int.Parse(input[1]);
            if (index >= 0 && index <= usernames.Count - 1)
            {
                string current = usernames[index];
                if (current != "Blacklisted" && current != "Lost")
                {
                    usernames[index] = "Lost";
                    lost.Add(current);
                    Console.WriteLine($"{current} was lost due to an error.");
                }
            }
            break;
        case "Change":
            index = int.Parse(input[1]);
            string newname = input[2];
            if (index >= 0 && index <= usernames.Count - 1)
            {
                string temp = usernames[index];
                usernames.RemoveAt(index);
                usernames.Insert(index, newname);
                Console.WriteLine($"{temp} changed his username to {newname}.");
            }
            break;  
    }
}
Console.WriteLine($"Blacklisted names: {blacklisted.Count}");
Console.WriteLine($"Lost names: {lost.Count}");
Console.WriteLine(string.Join(" ", usernames));