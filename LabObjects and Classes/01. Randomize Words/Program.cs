string[] words = Console.ReadLine().Split().ToArray();
Random random = new();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(0, words.Length);
    Swap(i, randomIndex, words);
}

foreach (string word in words)
{
    Console.WriteLine(word);
}
static void Swap(int firstIndex, int secondIndex, string[] words)
{
    string temp = words[firstIndex];
    words[firstIndex] = words[secondIndex];
    words[secondIndex] = temp;
}
