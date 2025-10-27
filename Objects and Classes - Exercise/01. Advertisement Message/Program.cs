using System;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        Random random = new Random();
        

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{phrases[Random(random, phrases.Length)]} {events[Random(random, events.Length)]} {authors[Random(random, authors.Length)]} - {cities[Random(random, cities.Length)]}");
        }


    }
    static int Random(Random random, int max)
    {
        return random.Next(max);
    }
}