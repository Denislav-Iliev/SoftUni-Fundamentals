using System.Diagnostics.Metrics;

List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = "";
int targetCounter = 0;

while ((command = Console.ReadLine()) != "End")
{
    int targetIndex = int.Parse(command);
    if (targetIndex < 0 || targetIndex > targets.Count - 1)
    {
        continue;
    }

    int targetValue = targets[targetIndex];
    if (targetValue == -1)
    {
        continue;
    }

    targets[targetIndex] = -1;
    targetCounter++;

    for (int i = 0; i < targets.Count; i++)
    {
        if (targets[i] == -1)
        {
            continue; 
        }
        else if (targetValue < targets[i])
        {
            targets[i] -= targetValue;
        }
        else if (targetValue >= targets[i])
        {
            targets[i] += targetValue;
        }
    }
}
Console.WriteLine($"Shot targets: {targetCounter} -> {string.Join(" ", targets)}");
