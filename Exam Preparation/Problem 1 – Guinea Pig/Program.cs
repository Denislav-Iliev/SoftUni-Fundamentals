double foodKg = double.Parse(Console.ReadLine());
double hayKg = double.Parse(Console.ReadLine());
double coverKg = double.Parse(Console.ReadLine());
double weightKg = double.Parse(Console.ReadLine());


double food = foodKg * 1000;
double hay = hayKg * 1000;
double cover = coverKg * 1000;
double weight = weightKg * 1000;

bool enough = true;

for (int day = 1; day <= 30; day++)
{

    food -= 300;
    if (food <= 0)
    { 
        enough = false;
        break;
    }

   
    if (day % 2 == 0)
    {
        double hayUsed = food * 0.05;
        hay -= hayUsed;
        if (hay <= 0) 
        { 
            enough = false; 
            break; 
        }
    }

    
    if (day % 3 == 0)
    {
        cover -= (weight / 3.0);
        if (cover <= 0) 
        { enough = false;
            break; 
        }
    }
}

if (enough)
{
    Console.WriteLine(
        $"Everything is fine! Puppy is happy! Food: {food / 1000:F2}, Hay: {hay / 1000:F2}, Cover: {cover / 1000:F2}.");
}
else
{
    Console.WriteLine("Merry must go to the pet store!");
}
