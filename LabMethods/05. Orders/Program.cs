internal class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double productprice = 0;

        switch (product)
        {
            case "coffee":
                productprice = 1.50;
                break;
            case "water":
                productprice = 1.00;
                break;
            case "coke":
                productprice = 1.40;
                break;
            case "snacks":
                productprice = 2.00;
                break;
        }
      Order(productprice, quantity);




    }
    static void Order(double productprice, int quantity)
    {
        Console.WriteLine($"{quantity * productprice:F2}");
    }



}