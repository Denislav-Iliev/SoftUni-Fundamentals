int queue = int.Parse(Console.ReadLine());
int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
int maxPeoplePerWagon = 4;

for (int i = 0; i < lift.Length; i++)
{
    int currentWagonCount = lift[i];

    for (int j = currentWagonCount; j < maxPeoplePerWagon; j++)
    {
        
        if (queue == 0)
        {
            if (lift.Sum() < lift.Length * maxPeoplePerWagon)
                Console.WriteLine("The lift has empty spots!");

            Console.WriteLine(string.Join(" ", lift));
            return;
        }

        lift[i]++;      
        queue--;        
    }
}

Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
Console.WriteLine(string.Join(" ", lift));
