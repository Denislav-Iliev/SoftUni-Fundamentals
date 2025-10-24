List<string> sequence = Console.ReadLine().Split().ToList();

string command = " ";
int moveCounter = 0;
bool isWon = false;
while ((command = Console.ReadLine()) != "end")
{
    int[] index = command.Split().Select(int.Parse).ToArray();
    int firstIndex = index[0];
    int secondIndex = index[1];
    moveCounter++;

    if (firstIndex == secondIndex ||
        (firstIndex < 0 || firstIndex > sequence.Count - 1) ||
        (secondIndex < 0 || secondIndex > sequence.Count - 1))
    {
        int middleIndex = sequence.Count / 2;
        string newSymbol = $"-{moveCounter}a";
        List<string> newElements = new List<string>() {newSymbol, newSymbol};
        sequence.InsertRange(middleIndex, newElements);
        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
    else
    {
        if (sequence[firstIndex] == sequence[secondIndex])
        {
            Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");
            if (firstIndex < secondIndex)
            {
                sequence.RemoveAt(firstIndex);
                sequence.RemoveAt(secondIndex);
            }
            else
            {
                sequence.RemoveAt(secondIndex);
                sequence.RemoveAt(firstIndex);
            }
        }
        else if (sequence[firstIndex] != sequence[secondIndex])
        {
            Console.WriteLine("Try again!");
        }

        if (sequence.Count == 0)
        {
            isWon = true;
            break;
        }
    }
}
if (isWon)
{
    Console.WriteLine($"You have won in {moveCounter} turns!");
}
else
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", sequence));
}
