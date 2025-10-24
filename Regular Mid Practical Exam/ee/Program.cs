double budget = double.Parse(Console.ReadLine());
int studentsQuantity = int.Parse(Console.ReadLine());
double flourPackagePrice = double.Parse(Console.ReadLine());
double singleEggPrice = double.Parse(Console.ReadLine());
double singleApronPrice = double.Parse(Console.ReadLine());
int flourNeededBeforeCal = 0;
int eggsNeeded = 0;
int apronNeededBeforeCal = 0;

for (int i = 1; i <= studentsQuantity; i++)
{
    flourNeededBeforeCal++;
    eggsNeeded += 10;
    apronNeededBeforeCal++;
}
double percentageToAdd = apronNeededBeforeCal * 0.20;
double apronNeeded = Math.Ceiling(apronNeededBeforeCal + percentageToAdd);
int free = flourNeededBeforeCal / 5;
int flourNeeded = flourNeededBeforeCal - free;

double totalCost = (flourNeeded * flourPackagePrice) + (eggsNeeded * singleEggPrice) + (apronNeeded * singleApronPrice);
if (totalCost <= budget)
{
    Console.WriteLine($"Items purchased for {totalCost:F2}$.");
}
else
{
    Console.WriteLine($"{totalCost - budget:F2}$ more needed.");
}