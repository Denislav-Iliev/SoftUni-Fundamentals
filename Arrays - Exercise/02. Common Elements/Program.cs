string[] firstArray = Console.ReadLine().Split().ToArray();
string[] secondArray = Console.ReadLine().Split().ToArray();
for (int i = 0; i < secondArray.Length; i++)
{
    for (int j = 0; j < firstArray.Length; j++)
    {
        if (secondArray[i].ToLower() == firstArray[j].ToLower())
            {
            Console.Write(secondArray[i] + " ");
            break;
        }
    }
}