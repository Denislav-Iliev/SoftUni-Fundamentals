List<string> chat  = new List<string>();

string input = "";

while ((input = Console.ReadLine()) != "end")
{
    string[] command = input.Split();
    switch (command[0])
    {
        case "Chat":
            string message = command[1];
            chat.Add(message);
            break;
        case "Delete":
            message = command[1];
            if (chat.Contains(message))
            {
                chat.Remove(message);
            }
            break;
        case "Edit":
            message = command[1];
            string newMessage = command[2];
            int index = chat.IndexOf(message);
            if (index >= 0 && index < chat.Count)
            {
                chat[index] = newMessage;              
            }
            break;
        case "Pin":
            message = command[1];
            index = chat.IndexOf(message);
            if (index >= 0 && index < chat.Count)
            {
                chat.RemoveAt(index);
                chat.Add(message);
            }
            break;
        case "Spam":
            for (int i = 1; i < command.Length; i++)
            {
                message = command[i];
                chat.Add(message);
            }
            break;
    }
}
Console.WriteLine(string.Join("\n", chat));