int countOrders = int.Parse(Console.ReadLine());
double orderPrice = 0;
double totalprice = 0;

for (int i = 1; i <= countOrders; i++)
{
    double priceperCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());
    orderPrice += ((days * capsuleCount) * priceperCapsule);
    Console.WriteLine($"The price for the coffee is: {orderPrice:F2}");
    totalprice += orderPrice;
}
Console.WriteLine($"Total: ${totalprice:F2}");

