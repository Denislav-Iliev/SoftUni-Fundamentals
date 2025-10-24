double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
Console.WriteLine(Result(width, height));

static double Result(double width, double height)
{
    return width * height;
}