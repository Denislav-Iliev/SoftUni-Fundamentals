string[] strings = Console.ReadLine().Split();

for (int i = 0; i < strings.Length / 2; i++)
{
    string tempElement = strings[i];
    strings[i] = strings[strings.Length - 1 - i];
    strings[strings.Length - 1 - i] = tempElement;
}
Console.WriteLine(string.Join(" ", strings));