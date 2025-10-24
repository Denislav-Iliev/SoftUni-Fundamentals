using System.Reflection;

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        string input = "";
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split("/").ToArray();
            switch (arguments[0])
            {
                case "Car":
                    Car newCar = new Car(arguments[1], arguments[2], int.Parse(arguments[3]));
                    catalog.Cars.Add(newCar);
                    break;
                case "Truck":
                    Truck newTruck = new Truck(arguments[1], arguments[2], int.Parse(arguments[3]));
                    catalog.Trucks.Add(newTruck);
                    break;
            }
        }
        catalog.Cars = catalog.Cars.OrderBy(car => car.Brand).ToList();
        catalog.Trucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
        Console.WriteLine("Cars:");
        foreach (var car in catalog.Cars)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine("Trucks:");
        foreach (var truck in catalog.Trucks)
        {
            Console.WriteLine(truck); 
        }
    }
}
class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
    public override string ToString()
    {
        return $"{Brand}: {Model} - {Weight}kg";
    }
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
    public override string ToString()
    {
        return $"{Brand}: {Model} - {HorsePower}hp";
    }
}
class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }
}